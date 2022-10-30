using System.Collections.Generic;

namespace AlışverişUygulaması
{
    public partial class Form1 : Form
    {
        List<AlisverisListesi> list = new List<AlisverisListesi>();
        AlisverisListesi listesi = new AlisverisListesi();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            showList();
        }

        void showList()
        {
            list = list.OrderBy(p => p.id).ToList();
            dataGridView1.DataSource = list;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ürün";
            dataGridView1.Columns[2].HeaderText = "Miktar";
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            var result = CheckTextBox();

            if (result) //boş değer yoksa işlemler yapacak.Bu kontrolü sağlamayıncada uygulama çöküyor.
            {
                var result2 = checkedId(Convert.ToInt16(textBox1.Text));

                if (result2)
                {
                    var result3 = checkedProductName(textBox2.Text);
                    if (result3)
                    {
                        AlisverisListesi alisverisListesi = new AlisverisListesi()
                        {
                            id = Convert.ToInt32(textBox1.Text),
                            name = textBox2.Text,
                            count = Convert.ToInt32(textBox3.Text),
                        };

                        list.Add(alisverisListesi);
                        showList();
                        ClearTextBox();
                    }
                   
                }
               
            }
            else
            {
                return;
            }
    
        }

        bool checkedProductName(string name)
        {
            foreach(var item in list)
            {
                if (item.name == name)
                {
                    MessageBox.Show("Bu Ürün Daha Önce Eklenmiş");
                    textBox2.Focus();
                    textBox2.SelectAll(); //bütün satırı seçiyor.
                    return false;
                }
            }
            return true;
        }
        bool checkedId(int id)
        {
            foreach(var item in list)
            {
                if (item.id == id)
                {
                    MessageBox.Show("Yazılan Id Daha Önce Kullanılmış");
                    textBox1.Focus();
                    return false;
                }
            }
            return true;
        }
        bool CheckTextBox()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Id Boş Olamaz");
                textBox1.Focus(); //boşsa eğer buraya yönlendirecek yazı satırını
                return false; //bunları unutursak program çöküyor.
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Ürün Boş Olamaz");
                textBox2.Focus();
                return false;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Miktar Boş Olamaz");
                textBox3.Focus();
                return false;
            }
          
            return true;

        }

        void ClearTextBox()
        {
            //id'yi yazılan değerin 1 arttırılmasını istedik otomatikleştirme gibi.
            textBox1.Text = (Convert.ToInt32(textBox1.Text)+1).ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox2.Focus(); //id yi 1 arttırdıkdan sonra textbox2 satırına otomatik geçiyor
        }
        private void buttonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Burası uygulama başlayınca otomatik çalıştığı bir yer

           
            listesi.id = 0;
            listesi.name = "Elma";
            listesi.count = 12;
            list.Add(listesi);

            AlisverisListesi alisverisListesi = new AlisverisListesi()
            {
                id = 1,
                name = "Armut",
                count = 3
            };
            list.Add(alisverisListesi);
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Yanlızca Rakam Girebilirsiniz");
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength-1);//son karaktere harf girince sildi örneğin
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Yanlızca Rakam Girebilirsiniz");
                textBox3.Text = textBox3.Text.Remove(textBox3.TextLength - 1);//son karaktere harf girince sildi örneğin
            }
        }
    }
}