using Proxy_for_obtaining.Proxy;

namespace Proxy_for_obtaining
{
    public partial class Form1 : Form
    {
        private IConsultationService _consultationService = new ConsultationProxy();

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Банківська консультація";
            this.Size = new System.Drawing.Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            var questionLabel = new Label
            {
                Text = "Оберіть питання для консультації:",
                Dock = DockStyle.Top
            };

            var questionComboBox = new ComboBox
            {
                Dock = DockStyle.Top
            };
            questionComboBox.Items.AddRange(new string[] { "Які звернення НБУ не розглядає", "За скільки часу отримаю відповідь", "Як оскаржити дії чи бездіяльність Національного банку" });

            var consultButton = new Button
            {
                Text = "Отримати консультацію",
                Dock = DockStyle.Top
            };
            consultButton.Click += (sender, e) =>
            {
                string selectedQuestion = questionComboBox.SelectedItem?.ToString();
                if (selectedQuestion != null)
                {
                    string consultationResult = _consultationService.GetConsultation(selectedQuestion);
                    MessageBox.Show(consultationResult, "Результат консультації");
                }
            };

            Controls.AddRange(new Control[] { consultButton, questionComboBox, questionLabel });
        }
    }
}
