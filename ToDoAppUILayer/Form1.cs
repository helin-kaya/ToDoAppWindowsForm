using ToDoAppBusinessLayer;
using ToDoAppDataLayer;
using ToDoAppEntityLayer.Entities;

namespace ToDoAppUILayer
{
    public partial class Form1 : Form
    {
        ToDoManager toDoManager = new ToDoManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnG�revEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ToDo td = new ToDo()
                {
                    Title = textBox1.Text.Trim(),
                    Description = textBox2.Text.Trim(),
                    CompletionDate = dateTimePicker1.Value,
                    IsActive = true,
                };
                if (toDoManager.AddNewToDo(td))
                {
                    MessageBox.Show($"Yeni g�rev eklendi!");

                }
                listBoxTamamlananlar.Items.Clear();
                listBoxYapilacaklar.Items.Clear();
                listelereEkle();
                G�revleriGriddeG�ster();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik sorun oldu! {ex.Message}");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G�revleriGriddeG�ster();

            listelereEkle();

        }

        private void G�revleriGriddeG�ster()
        {
            using (MyContext context = new MyContext())
            {
                List<ToDo> yapilacaklarListesi = context.ToDoTable.ToList();
                dataGridView1.DataSource = yapilacaklarListesi;
            }
        }

        private void listelereEkle()
        {
            using (MyContext context = new MyContext())
            {
                List<ToDo> tamamlananlar = context.ToDoTable.Where(y => y.IsActive == false).ToList();
                List<ToDo> yapilacaklar = context.ToDoTable.Where(y => y.IsActive == true).ToList();

                foreach (ToDo yapilacak in tamamlananlar)
                {
                    listBoxTamamlananlar.Items.Add(yapilacak.Title);
                    //listBoxTamamlananlar.Items.Add(yapilacak.CompletionDate);
                }

                foreach (ToDo yapilacak in yapilacaklar)
                {
                    listBoxYapilacaklar.Items.Add(yapilacak.Title);
                    //listBoxYapilacaklar.Items.Add(yapilacak.CompletionDate);
                }

            }
        }


        private int seciliGorevId;



        private void btnG�revSil_Click(object sender, EventArgs e)
        {

            try
            {

                if (seciliGorevId != 0)
                {
                    using (MyContext context = new MyContext())
                    {
                        ToDo yapilacak = context.ToDoTable.FirstOrDefault(y => y.Id == seciliGorevId);

                        if (yapilacak != null)
                        {

                            context.ToDoTable.Remove(yapilacak);
                            context.SaveChanges();

                            listBoxYapilacaklar.Items.Remove(yapilacak.Title);
                            seciliGorevId = 0; // Se�ili g�revin Id de�erini s�f�rla
                            G�revleriGriddeG�ster();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik sorun oldu! {ex.Message}");
            }

        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            if (listBoxYapilacaklar.SelectedItem != null)
            {
                string seciliGorev = listBoxYapilacaklar.SelectedItem.ToString();
                using (MyContext context = new MyContext())
                {
                    ToDo yapilacak = context.ToDoTable.FirstOrDefault(y => y.Title == seciliGorev && y.IsActive == true);

                    if (yapilacak != null)
                    {
                        yapilacak.IsActive = false;
                        context.SaveChanges();

                        listBoxYapilacaklar.Items.Remove(seciliGorev);
                        listBoxTamamlananlar.Items.Add(seciliGorev);
                    }
                }
            }
        }

        private void YAPILACAKLAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxYapilacaklar.SelectedItem != null)
                {
                    string seciliGorev = listBoxYapilacaklar.SelectedItem.ToString();
                    using (MyContext context = new MyContext())
                    {
                        ToDo yapilacak = context.ToDoTable.FirstOrDefault(y => y.Title == seciliGorev && y.IsActive == true);

                        if (yapilacak != null)
                        {
                            seciliGorevId = yapilacak.Id;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik sorun oldu! {ex.Message}");
            }
        }


    }
}