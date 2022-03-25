# SeturAssestment

Notlar
Appsetting.Json içinde, Db Bağlantı içi ConnectionString (PostgreSql) ve RabbitMQ için MessageBrokerOptions değerlerinin değiştirlmesi gerekmektedir.
Otomatik Migration Uygulanıyor.
SeedData Eklendi. 
Zaman Azlığından UnitTest , FluentValidation ,AutoMapper, MiddlewareLog kullanılmamıştır.
Teknolojiler
.NetCore WebApi
RabbitMQ
Swagger
PostgreSql

Test Api User;
admin@admin.com
Asd123

İsteklerin olduğu bir pdf dosyası: 
SeturAssestment\WebApi\api-doküman.pdf yolunda bulunmaktadır.
https://github.com/emingrblk/SeturAssestment/blob/main/SeturAssestment/WebApi/api-dok%C3%BCman.pdf
Web Api İstekleri Ve anlamları;

/api/Contacts : Tüm Kişileri Çeker

/api/Contacts/{id} :  Id'e ait Kişiyi Çeker.

/api/Contacts/add :  Kişi Ekler

/api/Contacts/update :  Kişiyi günceller

/api/Contacts/delete/{id} :  Id'e ait Kişiyi Siler.

/api/ContactDetails/add/{contactId} :  ContactId'e göre İletişim Bilgisi Ekler.

/api/ContactDetails/update/{contactId} :  ContactId'e göre İletişim Bilgisini Günceller.

/api/ContactDetails/delete/{contactDetailId} :  ContactDetailId'ye göre İletişim Bilgisini Siler.

/api/ReportRequests/RequestReport/{location} :  Lokasyon için Rapor İsteği Yapar (RabbitMq Producer)

/api/Reports : Tüm Raporları Getirir.
/api/Reports/{id} : Verilen Id'e ait raporları getirir.
