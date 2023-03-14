using System.Reflection.Metadata.Ecma335;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace RehberForm;

public class Kisi
{
    private string _telefon1;
    private string _telefon2;
    private string _eMail;
    private string _ad;
    private string _soyad;
    public string Ad
    {
        set
        {
            if (string.IsNullOrEmpty(value) || !HepsiHarfMi(value))
            {
                throw new Exception("İsim, sayı veya özel karakter içeremez.");
            }
            _ad = value;
        }
        get => IlkHarfiBuyukYap(_ad);
    }
    public string Soyad
    {
        set
        {
            if (string.IsNullOrEmpty(value) || !HepsiHarfMi(value))
            {
                throw new Exception("Soyisim, sayı veya özel karakter içeremez.");
            }
            _soyad = value;
        }
        get => _soyad.ToUpper();
    }
    public string Telefon1
    {
        set
        {
            if (string.IsNullOrEmpty(value) || !HepsiRakamMı(value) || value.Length != 10)
            {
                throw new Exception("Telefon no 10 haneli olmalı ve rakamlardan oluşmalı");
            }
            _telefon1 = value;
        }
        get => _telefon1;
    }
    public string Telefon2
    {
        set
        {
            if (value.Length == 0)
            {
                _telefon2 = null;
            }
            else if (string.IsNullOrEmpty(value) || !HepsiRakamMı(value) || value.Length != 10)
            {
                throw new Exception("Telefon no 10 haneli olmalı ve rakamlardan oluşmalı");
            }

            _telefon2 = value;
        }
        get => _telefon2;
    }
    public string WebAdres { get; set; }
    public string Email
    {
        set
        {
            string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(value, emailRegex, RegexOptions.IgnoreCase))
            {
                throw new Exception("Doğru bir email adresi giremediniz.");
            }
            _eMail = value;

        }
        get => _eMail;
    }
    public string Adres { get; set; }
    public string Aciklama { get; set; }

    public override string ToString()
    {
        return Ad + " " + Soyad;
    }
    private bool HepsiHarfMi(string girdi)
    {
        foreach (char item in girdi)
        {
            if (!char.IsLetter(item))
            {
                return false;
            }
        }
        return true;
    }
    private bool HepsiRakamMı(string girdi)
    {
        foreach (char item in girdi)
        {
            if (!char.IsDigit(item))
            {
                return false;
            }
        }
        return true;
    }
    private string IlkHarfiBuyukYap(string girdi)
    {
        if (girdi.Length == 1)
            return girdi.ToUpper();
        else
            return char.ToUpper(girdi[0]) + girdi.Substring(1).ToLower();
    }
}


