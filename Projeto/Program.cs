
namespace Projeto {

    

    public class Menu {





        static void Main(string[] args) {
            Menu.MenuForm();
        }


        

        public static void MenuForm() {
            Form menuForm = new Form();
            menuForm.Text = "Menu";
            menuForm.Width = 300;
            menuForm.Height = 300;
            menuForm.StartPosition = FormStartPosition.CenterScreen;
            menuForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            menuForm.MaximizeBox = false;
            menuForm.MinimizeBox = false;
            menuForm.ShowIcon = false;
            menuForm.ShowInTaskbar = false;
            menuForm.TopMost = true;
            menuForm.FormClosed += (sender, e) => { menuForm.Dispose(); };



            TextBox texto = new TextBox();
            texto.Top = 20;
            texto.Left = 30;
            texto.Width = 200;

            Button olaButtom = new Button();
            olaButtom.Text = "Sair";
            olaButtom.Top =100 ;
            olaButtom.Left = 10;
            olaButtom.Width = 250;
            olaButtom.Click += (sender, e) =>
            {
                menuForm.Close();
            };


            Button sairButton = new Button();
            sairButton.Text = "Olá";
            sairButton.Top = 60;
            sairButton.Left = 10;
            sairButton.Width = 250;
            sairButton.Click += (sender, e) => 
            { 
                olaPessoa(texto.Text);
                menuForm.Hide(); 
                menuForm.Close();   

            };
            
            menuForm.Controls.Add(texto);
            menuForm.Controls.Add(sairButton);
            menuForm.Controls.Add(olaButtom);
            menuForm.ShowDialog();







             static void olaPessoa(string nome)
                    {
                        
                                DialogResult result = MessageBox.Show("Quer adicionar outro nome?", $"Hola {nome}", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                    MenuForm();
                            }
                        else
                        {
                            MessageBox.Show("Obrigado <3");
                        }
        }

        }
    }

}