//oluşturulan proje Ntier Katmanlı projesidir.
 --3 adet katman oluşturuldu.
	--DAL => Data Acces Layer 
	--BLL => Business Logic Layer
	--UI  => User Interface
-----------------------------------------------

DAL => Data Acces Layer 
DAL içerisinde sadece ver,tabnını barındırına katman olarak açıldı.
  --Görevi sadece bağlı bulunduğu veriler ve o verilere ait entityler olacaktır.
  DAL katmanı içerisinde MODEL isminde bir klasör oluşturuldu.Bu klasörün oluşturulma amacı ise içerisinde sadece veritabanının yansımasını tutmak içindir. Bu yüzden Model1.edmx uzantılı yansımayı bu klasör içerisine DbFirst kullanarak çektik.

BLL => Business Logic Layer
BLL katmanı DAL katmanı içerisinde bulunan veritabnına doğrudan baglanarak UI katmanı içerisinden talep edilen işlmelieri getirmekle yükümlü katman olarak oluşturuldu.
  **BLL katmanı DAL katmanından referans alır.

 Bütün işlemler UI katmanında görüntüleneceği için;
 DAL ve BLL katmanlarını UI katmanına referans vermemiz gerekir.