using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace Tris_PI_2020.ViewModels
{
    public class SearchRequestData
    {
        [Display(Name = "В наличии")]
        public bool IsInStore { get; set; }

        [Display(Name = "Наименование")]
        public string SearchLine { get; set; }

        [Display(Name = "Изготовлен после")]
        [DataType(DataType.Date)]
        public DateTime ProducedAfter { get; set; }

        [Display(Name = "Максимальная цена")]
        public decimal MaxPrice { get; set; }

        [Display(Name = "Категория")]
        public string Category { get; set; }
    }

}
