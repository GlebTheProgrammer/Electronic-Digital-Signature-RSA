using EDS.Domain;
using System.IO;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace EDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetDefaultPAndQCheck()
        {
            pError.Text = "None.";
            pError.ForeColor = Color.Black;

            qError.Text = "None.";
            qError.ForeColor = Color.Black;

            QTextBox.Enabled = true;
            PTextBox.Enabled = true;
            ApplyQAndPButton.Enabled = true;
            StartPrimalTestButton.Enabled = false;
        }

        private void ApplyQAndPButton_Click(object sender, EventArgs e)
        {
            // Убираем лишние символы из TextBox - ов
            PTextBox.Text = ValuesChecker.ValidateTextBoxInput(PTextBox.Text);
            QTextBox.Text = ValuesChecker.ValidateTextBoxInput(QTextBox.Text);

            // Проверяем TextBox - ы на правильность чисел внутри
            string pCheckResult = ValuesChecker.CheckTextBoxForInputErrors(PTextBox.Text);
            string qCheckResult = ValuesChecker.CheckTextBoxForInputErrors(QTextBox.Text);

            if (pCheckResult != string.Empty)
            {
                pError.Text = pCheckResult;
                pError.ForeColor = Color.Red;
            }
            else
            {
                pError.Text = "None.";
                pError.ForeColor = Color.Green;
            }

            if (qCheckResult != string.Empty)
            {
                qError.Text = qCheckResult;
                qError.ForeColor = Color.Red;
            }
            else
            {
                qError.Text = "None.";
                qError.ForeColor = Color.Green;
            }

            if (pError.ForeColor == Color.Green && qError.ForeColor == Color.Green)
            {
                PTextBox.Enabled = false;
                QTextBox.Enabled = false;
                ApplyQAndPButton.Enabled = false;

                StartPrimalTestButton.Enabled = true;
            }
        }

        private void StartPrimalTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger p = BigInteger.Parse(PTextBox.Text);
                BigInteger q = BigInteger.Parse(QTextBox.Text);

                bool pResult = ValuesChecker.IsPrimary_MillersRabinsTest(p, 10);
                bool qResult = ValuesChecker.IsPrimary_MillersRabinsTest(q, 10);

                if (!pResult && !qResult)
                {
                    PrimalTestResultLabel.Text = "p And q Are Not Primal.";
                    PrimalTestResultLabel.ForeColor = Color.Red;
                    SetDefaultPAndQCheck();
                    return;
                }
                if (pResult && !qResult)
                {
                    PrimalTestResultLabel.Text = "p Is Primal And q Is Not Primal.";
                    PrimalTestResultLabel.ForeColor = Color.Red;
                    SetDefaultPAndQCheck();
                    return;
                }
                if (!pResult && qResult)
                {
                    PrimalTestResultLabel.Text = "p Is Not Primal And q Is Primal.";
                    PrimalTestResultLabel.ForeColor = Color.Red;
                    SetDefaultPAndQCheck();
                    return;
                }
                if (pResult && qResult)
                {
                    PrimalTestResultLabel.Text = "p And q Are Primal.";
                    PrimalTestResultLabel.ForeColor = Color.Green;

                    rValueLabel.Text = Convert.ToString(p * q);
                    FrValueLabel.Text = Convert.ToString((p-1) * (q-1));

                    ValuesContainer.p = p;
                    ValuesContainer.q = q;
                    ValuesContainer.r = p * q;
                    ValuesContainer.Fr = (p - 1) * (q - 1);

                    ChooseFileButton.Enabled = true;
                    StartPrimalTestButton.Enabled = false;

                    return;
                }
            }
            catch (Exception ex)
            {
                string errorMssg = ex.Message;
                PrimalTestResultLabel.Text = errorMssg;
                PrimalTestResultLabel.ForeColor = Color.Red;
                SetDefaultPAndQCheck();
                return;
            }
        }

        private void ApplyEButton_Click(object sender, EventArgs e)
        {
            // Убираем лишние символы из TextBox - а
            ETextBox.Text = ValuesChecker.ValidateTextBoxInput(ETextBox.Text);

            // Получаем значение Ф(r) из label
            BigInteger Fr = ValuesContainer.Fr;

            // Проверка значения text box на то, что там записано число и ничто другое
            string eCheckResult = ValuesChecker.CheckTextBoxWithEForInputErrors(ETextBox.Text, Fr);

            // Окраска сообщения и назначение текста сообщения в зависимости от результата eCheckValueResult
            if (eCheckResult != string.Empty)
            {
                eError.Text = eCheckResult;
                eError.ForeColor = Color.Red;
            }
            else
            {
                eError.Text = "None.";
                eError.ForeColor = Color.Green;
            }

            // Если ошибка не была обнаружена, то находим коэффициенты Безу при помощи расширенного алгоритма Евклида
            if (eError.ForeColor == Color.Green)
            {
                // Коэффициенты Безу
                BigInteger value1;
                BigInteger value2;

                ValuesContainer.e = BigInteger.Parse(ETextBox.Text);

                // НОД, всегда будет получаться равное 1
                BigInteger gcd = ValuesChecker.GetGcdAndBezuDigits(ValuesContainer.e, Fr, out value1, out value2);

                // Получение d как большее значение из коэффициентов Безу
                if (value1 > value2)
                {
                    ValuesContainer.d = value1;
                    dValueLabel.Text = Convert.ToString(ValuesContainer.d);
                }
                else
                {
                    ValuesContainer.d = value2;
                    dValueLabel.Text = Convert.ToString(ValuesContainer.d);
                }

                GetEDSButton.Enabled = true;
                ETextBox.Enabled = false;
                ApplyEButton.Enabled = false;
            }
        }

        private void InputFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = ofd.FileName;
                GetHashButton.Enabled = true;
                ChooseFileButton.Enabled = false;
            }
        }

        private void GetHashButton_Click(object sender, EventArgs e)
        {
            FileContext.TakeBytesFromPath(FilePathTextBox.Text);

            if (FileContext.bufferByte == null)
                return;

            FileContext.GetHashCodesFromByteArray(100, ValuesContainer.r);

            if (FileContext.hashArray == null)
                return;

            InputHashTextBox.Text = String.Join(Environment.NewLine, FileContext.hashArray);

            ETextBox.Enabled = true;
            ApplyEButton.Enabled = true;
            GetHashButton.Enabled = false;

            ValuesContainer.MssgHash = FileContext.hashArray[FileContext.hashArray.Length - 1];
            MessageHashCodeValueLabel.Text = ValuesContainer.MssgHash.ToString();
        }

        private void GetEDSButton_Click(object sender, EventArgs e)
        {
            BigInteger EDS = ValuesChecker.FastPowModFunc(ValuesContainer.MssgHash,
                ValuesContainer.e, ValuesContainer.r);

            EDSValueLabel.Text = EDS.ToString();

            GetEDSButton.Enabled = false;
            ChooseEDSButton.Enabled = true;
        }

        private void ChooseEDSButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = ofd.FileName;
                ChooseEDSButton.Enabled = false;
                SaveEDSButton.Enabled = true;
            }
        }

        private void SaveEDSButton_Click(object sender, EventArgs e)
{
            using (StreamWriter writer = new StreamWriter(FilePathTextBox.Text, false))
            {
                writer.WriteLine(EDSValueLabel.Text);
            }
            MessageBox.Show("EDS was saved successfully.");
        }

        private void ChooseSenderFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = ofd.FileName;
                ChooseSenderFileButton.Enabled = false;
                ChooseExistingEDSButton.Enabled = true;
            }
        }

        private void CheckingEDSModeButton_Click(object sender, EventArgs e)
        {
            pError.Text = "None.";
            pError.ForeColor = Color.Black;
            PTextBox.Enabled = false;
            PTextBox.Text = String.Empty;

            qError.Text = "None.";
            qError.ForeColor = Color.Black;
            QTextBox.Enabled = false;
            QTextBox.Text = String.Empty;

            ApplyQAndPButton.Enabled = false;
            StartPrimalTestButton.Enabled = false;

            PrimalTestResultLabel.Text = "None.";
            PrimalTestResultLabel.ForeColor = Color.Black;

            rValueLabel.Text = "None.";
            FrValueLabel.Text = "None.";
            dValueLabel.Text = "None.";

            eError.Text = "None.";
            eError.ForeColor = Color.Black;
            PTextBox.Enabled = false;
            ETextBox.Enabled = false;
            ETextBox.Text = String.Empty;
            ApplyEButton.Enabled = false;

            MakingEDSModeButton.Enabled = true;
            CheckingEDSModeButton.Enabled = false;
            InputHashTextBox.Text = String.Empty;

            MessageHashCodeValueLabel.Text = "None.";
            EDSValueLabel.Text = "None.";

            FilePathTextBox.Text = String.Empty;
            ChooseFileButton.Enabled = false;
            GetHashButton.Enabled = false;
            GetEDSButton.Enabled = false;
            ChooseSenderFileButton.Enabled = true;
            GetSenderHashButton.Enabled = false;
            CheckEDSButton.Enabled = false;

            EDSPathTextBox.Text = String.Empty;
            ChooseEDSButton.Enabled = false;
            SaveEDSButton.Enabled = false;
            ChooseExistingEDSButton.Enabled = false;

            eSenderError.Text = "None.";
            eSenderError.ForeColor = Color.Black;
            eSenderTextBox.Enabled = false;
            eSenderTextBox.Text = String.Empty;

            rSenderError.Text = "None.";
            rSenderError.ForeColor = Color.Black;
            rSenderTextBox.Enabled = false;
            rSenderTextBox.Text = String.Empty;

            SubmitSenderButton.Enabled = false;

        }

        private void MakingEDSModeButton_Click(object sender, EventArgs e)
        {
            PTextBox.Enabled = true;
            QTextBox.Enabled = true;

            pError.Text = "None.";
            pError.ForeColor = Color.Black;
            PTextBox.Text = String.Empty;

            qError.Text = "None.";
            qError.ForeColor = Color.Black;

            QTextBox.Text = String.Empty;

            ApplyQAndPButton.Enabled = true;
            StartPrimalTestButton.Enabled = false;

            PrimalTestResultLabel.Text = "None.";
            PrimalTestResultLabel.ForeColor = Color.Black;

            rValueLabel.Text = "None.";
            FrValueLabel.Text = "None.";
            dValueLabel.Text = "None.";

            eError.Text = "None.";
            eError.ForeColor = Color.Black;
            ETextBox.Enabled = false;
            ETextBox.Text = String.Empty;
            ApplyEButton.Enabled = false;

            MakingEDSModeButton.Enabled = false;
            CheckingEDSModeButton.Enabled = true;
            InputHashTextBox.Text = String.Empty;

            MessageHashCodeValueLabel.Text = "None.";
            EDSValueLabel.Text = "None.";

            FilePathTextBox.Text = String.Empty;
            ChooseFileButton.Enabled = false;
            GetHashButton.Enabled = false;
            GetEDSButton.Enabled = false;
            ChooseSenderFileButton.Enabled = false;
            GetSenderHashButton.Enabled = false;
            CheckEDSButton.Enabled = false;

            EDSPathTextBox.Text = String.Empty;
            ChooseEDSButton.Enabled = false;
            SaveEDSButton.Enabled = false;
            ChooseExistingEDSButton.Enabled = false;

            eSenderError.Text = "None.";
            eSenderError.ForeColor = Color.Black;
            eSenderTextBox.Enabled = false;
            eSenderTextBox.Text = String.Empty;

            rSenderError.Text = "None.";
            rSenderError.ForeColor = Color.Black;
            rSenderTextBox.Enabled = false;
            rSenderTextBox.Text = String.Empty;

            SubmitSenderButton.Enabled = false;
        }

        private void ChooseExistingEDSButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                EDSPathTextBox.Text = ofd.FileName;
                ChooseExistingEDSButton.Enabled = false;


                eSenderTextBox.Enabled = true;
                rSenderTextBox.Enabled = true;
                SubmitSenderButton.Enabled = true;
            }
        }

        private void SubmitSenderButton_Click(object sender, EventArgs e)
        {
            // Убираем лишние символы из TextBox - ов
            eSenderTextBox.Text = ValuesChecker.ValidateTextBoxInput(eSenderTextBox.Text);
            rSenderTextBox.Text = ValuesChecker.ValidateTextBoxInput(rSenderTextBox.Text);

            // Проверяем TextBox - ы на правильность чисел внутри
            string eCheckResult = ValuesChecker.CheckTextBoxForInputErrors(eSenderTextBox.Text);
            string rCheckResult = ValuesChecker.CheckTextBoxForInputErrors(rSenderTextBox.Text);

            if (eCheckResult != string.Empty)
            {
                eSenderError.Text = eCheckResult;
                eSenderError.ForeColor = Color.Red;
            }
            else
            {
                eSenderError.Text = "None.";
                eSenderError.ForeColor = Color.Green;
            }

            if (rCheckResult != string.Empty)
            {
                rSenderError.Text = rCheckResult;
                rSenderError.ForeColor = Color.Red;
            }
            else
            {
                rSenderError.Text = "None.";
                rSenderError.ForeColor = Color.Green;
            }

            if (eSenderError.ForeColor == Color.Green && rSenderError.ForeColor == Color.Green)
            {
                eSenderTextBox.Enabled = false;
                rSenderTextBox.Enabled = false;
                SubmitSenderButton.Enabled = false;

                GetSenderHashButton.Enabled = true;

                ValuesContainer.e = BigInteger.Parse(eSenderTextBox.Text);
                ValuesContainer.r = BigInteger.Parse(rSenderTextBox.Text);
            }
        }

        private void GetSenderHashButton_Click(object sender, EventArgs e)
        {
            FileContext.TakeBytesFromPath(FilePathTextBox.Text);

            if (FileContext.bufferByte == null)
                return;

            FileContext.GetHashCodesFromByteArray(100, ValuesContainer.r);

            if (FileContext.hashArray == null)
                return;

            InputHashTextBox.Text = String.Join(Environment.NewLine, FileContext.hashArray);

            GetSenderHashButton.Enabled = false;
            CheckEDSButton.Enabled = true;

            ValuesContainer.MssgHash = FileContext.hashArray[FileContext.hashArray.Length - 1];
            MessageHashCodeValueLabel.Text = ValuesContainer.MssgHash.ToString();
        }

        private void CheckEDSButton_Click(object sender, EventArgs e)
        {
            FileContext.TakeEDSFromFile(EDSPathTextBox.Text);
            ValuesContainer.EDS = ValuesChecker.FastPowModFunc((BigInteger)FileContext.EDS, ValuesContainer.e, ValuesContainer.r);
            EDSValueLabel.Text = ValuesContainer.EDS.ToString();

            if (ValuesContainer.EDS != ValuesContainer.MssgHash)
                MessageBox.Show("ВНИМАНИЕ!!!!! ФАЙЛ НЕ ЯВЛЯЕТСЯ ПОДЛИНЫМ!!!!!!");
            else
                MessageBox.Show("Всё в порядке. Файл подлиный.");
        }
    }
}