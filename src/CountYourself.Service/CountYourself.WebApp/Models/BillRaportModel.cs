using System;
namespace CountYourself.WebApp.Models
{
	public class BillRaportModel
	{
		public List<BillModel> Bills { get; set; } = new List<BillModel>();

        public decimal SumOfValues
        {
            get
            {
                return Bills.Sum(x => x.Value);
            }
        }
	}
}

