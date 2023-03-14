using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RehberForm;

public partial class Form1 : Form
{
    private DataContext _context;
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        var data = DataHelper.Load();
        _context = data ?? new DataContext();
        lstKisiler.DataSource = _context.Kisiler;
        lstKisiler.SelectedItem = null;
        FormCleaner();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            Kisi kisi = new Kisi()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 = txtTelefon2.Text,
                Email = txtEmail.Text,
                Aciklama = txtAçýklama.Text,
                Adres = txtAdres.Text,
                WebAdres = txtWebAdres.Text,
            };
            _context.Kisiler.Insert(0, kisi);
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = _context.Kisiler;
            lstKisiler.SelectedIndex = -1;
            DataHelper.Save(_context);
            FormCleaner();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

    private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstKisiler.SelectedItem == null) return;
        Kisi secilenKisi = (Kisi)lstKisiler.SelectedItem;
        txtAd.Text = secilenKisi.Ad;
        txtAdres.Text = secilenKisi.Adres;
        txtSoyad.Text = secilenKisi.Soyad;
        txtEmail.Text = secilenKisi.Email;
        txtAçýklama.Text = secilenKisi.Aciklama;
        txtTelefon1.Text = secilenKisi.Telefon1;
        txtTelefon2.Text = secilenKisi.Telefon2;
        txtWebAdres.Text = secilenKisi.WebAdres;
    }
    private void FormCleaner()
    {
        foreach (var item in this.Controls)
        {
            if (item is TextBox txt)
                txt.Text = string.Empty;
        }
    }

    private void Form1_Click(object sender, EventArgs e)
    {
        lstKisiler.SelectedIndex = -1;
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (lstKisiler.SelectedItem == null) return;
        try
        {
            Kisi secilenKisi = (Kisi)lstKisiler.SelectedItem;
            secilenKisi.Ad = txtAd.Text;
            secilenKisi.Soyad = txtSoyad.Text;
            secilenKisi.Telefon1 = txtTelefon1.Text;
            secilenKisi.Telefon2 = txtTelefon2.Text;
            secilenKisi.Email = txtEmail.Text;
            secilenKisi.Aciklama = txtAçýklama.Text;
            secilenKisi.Adres = txtAdres.Text;
            secilenKisi.WebAdres = txtWebAdres.Text;
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = _context.Kisiler;
            lstKisiler.SelectedIndex = -1;
            DataHelper.Save(_context);
            FormCleaner();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
        if (lstKisiler.SelectedItem == null) return;
        Kisi secilenKisi = (Kisi)lstKisiler.SelectedItem;
        _context.Kisiler.Remove(secilenKisi);
        lstKisiler.DataSource = null;
        lstKisiler.DataSource = _context.Kisiler;
        lstKisiler.SelectedIndex = -1;
        DataHelper.Save(_context);
        FormCleaner();
    }
}