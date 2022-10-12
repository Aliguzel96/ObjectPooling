



(&#x1F534;): Pooling pattern nedir? Bir obje ile işiniz bittikten sonra o objeyi yok etmek yerine, objeyi havuz dediğimiz bir yerde tutup daha sonra aynı türde bir objeye ihtiyaç duyduğunuzda, yeni bir obje oluşturmak yerine havuzdaki objeyi tekrardan kullanmaktır. 
Bu şekilde Instantiate ve Destroy fonksiyonlarını minimuma indirebilirsiniz. 


 (&#x1F53B;):
Özellikle mobil oyunlarda, sürekli Instantiate/Destroy yapıyorsanız, bu pattern performansı ciddi anlamda iyileştirebilir. 
Ancak bu pattern’i aşırı abartmaya da gerek yok. Bir objeden oyun boyunca sadece 1-2 defa Instantiate/Destroy ediyorsanız, burada pooling pattern’i kullanmasanız da olur.

(&#x1F539;):
Eğer havuzun kapasitesini biliyorsanız bir array kullanabileceğiniz gibi, dinamik havuzlar için List veya Stack de kullanabilirsiniz. Stack veri türü, List veri türüne çok benzer. Aralarındaki temel farklar şunlardır:

(&#x1F539;):
List’te listObjesi[0] şeklinde List’teki herhangi bir elemana erişebilirken bu Stack’te mümkün değildir.
List.Add fonksiyonunun karşılığı Stack.Push‘tur (List/Stack’in sonuna yeni bir obje eklemeye yarar).
Stack’te Pop fonksiyonu bulunmaktadır; bu fonksiyon Stack’in en sonundaki objeyi döndürür ve aynı zamanda bu objeyi Stack’ten çıkarır.

Stack‘teki Push ve Pop fonksiyonları, havuza eleman ekleyip havuzdan eleman çıkarmak için çok idealdir.


 (&#x1F4D8;):
Ref: https://yasirkula.com/2019/10/30/unity-pooling-obje-havuzu-patterni/
