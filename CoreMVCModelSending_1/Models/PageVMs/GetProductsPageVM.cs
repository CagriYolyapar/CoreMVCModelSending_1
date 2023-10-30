using CoreMVCModelSending_1.Models.Tools;

namespace CoreMVCModelSending_1.Models.PageVMs
{
    public class GetProductsPageVM
    {
        public List<Product>  Products { get; set; }
        public Category Category { get; set; }
        public List<Shipper> Shippers { get; set; }
      



    }
}
