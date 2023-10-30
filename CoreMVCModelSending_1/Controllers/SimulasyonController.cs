using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_1.Controllers
{
    public class SimulasyonController : Controller
    {


        public IActionResult Index()
        {

            //Eger bir View metodu bir string argüman ile cagrılıyorsa artık icinde cagrıldıgı Action isminde bir View sayfası aramaz sizin ona verdiginiz string argüman isminde bir View sayfası arar... Ancak bilmelisiniz bir View'in bu sekilde kullanılması standart degildir...Cünkü biz View'ların Action isimleriyle denk düsmesini isteriz ki Projemiz icerisinde barındırılan kodlar temiz bir şekilde gözüksün...


            //View metodu, icerisine bir argüman verilmeden cagrıldıgı zaman hangi Action icerisindeyse o Action ile aynı isimde View döndürme görevine sahiptir...Ancak bir View metoduna explicit bir şekilde (acıkca) string bir tipte argüman verilirse o zaman o isimde bir View'i döndürmeye calısır...





            return View("Deneme");
        }
    }
}
