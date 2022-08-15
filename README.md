![image](https://user-images.githubusercontent.com/96024765/184668836-42736858-9ba7-4a18-a21e-c409f7eeb27d.png)
Bu form uygulaması ile personeller tabloma form üzerinden ekleme , güncelleme , silme , id ye göre veri bulma ve listeleme işlemlerini gerçekleştirdim.

Veri tabanı bağlantımı PersonelForm içerisindeki config dosyasında connectionStrings etiketi içerisine yazdım. Veri tabanına PersonelManagerLibrary DLL'inin içerisindeki PersonelManager sınıfı ile eriştim ve veri tabanı işlemlerini de bu sınıfta gerçekleştirdim. Veri tabanı işlemlerini gerçekleştirirken tablom için oluşturduğum sp_add , sp_GetirById , sp_Listele , sp_Sil ve sp_Güncelle sp lerini kullandım.
