namespace LB1 {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // получение данных
            using (ApplicationContext db = new ApplicationContext()) {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                labelUsers.Text = "Список пользователей: ";
                foreach (User u in users) {
                    labelInfAboutUsers.Text += ($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }
    }
}
