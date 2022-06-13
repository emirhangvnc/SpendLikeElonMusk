
namespace Business.Constants
{
    public static class Messages
    {
        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted = "Kategori Silindi";
        public static string CategoryUpdated = "Kategori Güncellendi";
        public static string CategoryListed = "Kategoriler Listelendi";

        public static string CompanyWealthAdded = "Şirket Varlığı Eklendi";
        public static string CompanyWealthDeleted = "Şirket Varlığı Silindi";
        public static string CompanyWealthUpdated = "Şirket Varlığı Güncellendi";
        public static string CompanyWealthListed = "Şirket Varlıkları Listelendi";

        public static string FavoriteAdded = "Favori Eklendi";
        public static string FavoriteDeleted = "Favori Silindi";
        public static string FavoriteUpdated = "Favori Güncellendi";
        public static string FavoriteListed = "Favoriler Listelendi";

        public static string FortuneAdded = "Servet Eklendi";
        public static string FortuneDeleted = "Servet Silindi";
        public static string FortuneUpdated = "Servet Güncellendi";
        public static string FortuneListed = "Servetler Listelendi";

        public static string PersonalWealthAdded = "Kişisel Servet Eklendi";
        public static string PersonalWealthDeleted = "Kişisel Servet Silindi";
        public static string PersonalWealthUpdated = "Kişisel Servet Güncellendi";
        public static string PersonalWealthListed = "Kişisel Servetler Listelendi";

        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductListed = "Ürünler Listelendi";

        public static string CategoryNotFound = "Kategori Bulunamadı";
        public static string CompanyWealthNotFound = "Şirket Varlığı Bulunamadı";
        public static string FavoriteNotFound = "Favori Bulunamadı";
        public static string FortuneNotFound = "Servet Bulunamadı";
        public static string PersonalWealthNotFound = "Kişisel Servet Bulunamadı";
        public static string ProductNotFound = "Ürün Bulunamadı";

        public static string Max50Caracter = "En Fazla 50 Karakter Olabilir";
        public static string Max30Caracter = "En Fazla 30 Karakter Olabilir";
        public static string Max20Caracter = "En Fazla 20 Karakter Olabilir";

        public static string Min2Caracter = "En Az 2 Karakter Olmalıdır";

        public static string NotEmpty = "Alanı Boş Bırakılamaz";
        public static string ProductImageMustBeExists = "Ürün Resmi Ekleyiniz";

        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
        public static string ProductImageNotFound = "Ürün Resmi Bulunamadı";
        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);
    }
}