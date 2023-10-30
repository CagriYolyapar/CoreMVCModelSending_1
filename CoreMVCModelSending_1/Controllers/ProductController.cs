using CoreMVCModelSending_1.Models.PageVMs;
using CoreMVCModelSending_1.Models.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_1.Controllers
{
    public class ProductController : Controller
    {

        #region OnemliNotlar



        //Bir View metodunun farklı bir View döndürmesi ile Model göndermesi arasında fark vardır... Bu metodun overloadlarindan birinde acık bir şekilde bir string parametre tanımlaması yapıldıgından dolayı metodun object parametre alan bir overload'i olmasına ragmen ilgili Metot bir string argümanla cagrılırsa string parametreli overload'i calısır...Onun object parametreli overload'ini calıstırmak icin string argümanı object'e acıkca cast etmeniz gerekir...Yani siz nasıl olsa her şey object'e gidiyor diye o ilgili overload'in calısacagını düsünmemelisiniz...Yani siz bu bilgiyi gözden kacırırsanız  verdiginiz string argümanın veri göndermek oldugunu (model göndermek oldugunu) zannedersiniz ama aslında o isimde bir sayfa döndürme görevi yapılır...

        //Model Göndermek Front End'de göstermek istediginiz bilgileri Back End'den Front End'e yollamak veya Front End'den almak istediginiz verileri Front End'den Back End'e göndermenin bir yoludur...Eger bu bilgi string bir tipte yollanacak ise o zaman string veririsinin object'e cast edilerek argüman olarak verilmesi gerekir(Cünkü View metodunda acıkca string parametre alan bir overload vardır)



        //Bir Model gönderiliyorsa karşılanmak zorundadır...

        //Model'in karsılanması View sayfasında @model(buradaki kücük m harfine dikkat ediniz)  diyerek gönderdiginiz verinin orijinal tipini yazmanız sayesinde olur...Model karsılandıktan sonra o ilgili verinin gösterilmesini istiyorsanız ise karsıladıgınız Model'i artık cagırmanız gerekir...Bu da @Model (büyük M harfine dikkat ediniz)


        //Normal sartlarda bir Domain Entity Bir RequestModels  , ResponseModels  yapılarının ve ek olarak PageVM yapılarının olması gereklidir...PageVMler de keza Request Response olarak ayrılırlar...


        #endregion
        public IActionResult Index()
        {

           

            return View("Merhaba ben veriyim" as object);
        }

        public IActionResult GetProducts()
        {
            List<Product> products = new()
            {
                new() {ID =  1, ProductName = "Tadelle",UnitPrice = 20},
                new() {ID =  2, ProductName = "Biskrem",UnitPrice = 10},
                new() {ID =  3, ProductName = "Cizi",UnitPrice = 7},

            };

            Category c = new()
            {
                CategoryName = "Tatlılar",
                Description = "Sekerlemeler vs..."
            };

            GetProductsPageVM gpVm = new()
            {
                Products = products,
                Category = c
            };


            return View(gpVm);
        }


        public IActionResult CreateProduct()
        {
            //Biz eger BackEnd'den Front End'e bir model göndermiyorsak...Ama buna ragmen Front End sanki bir model karsılıyormus gibi bir ifade kullandıysa anlayın ki bu sefer bu demektir ki Front End Back End'e bir model gönderiyor...
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
