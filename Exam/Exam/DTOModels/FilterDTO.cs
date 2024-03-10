using DAL.Enums;

namespace Exam.DTOModels
{
    public class FilterDTO
    {
        public bool FilterByMaxPrice { get; set; }
        public bool FilterByMinPrice { get; set; }
        public bool FilterByFitment { get; set; }
        public bool FilterByStatus { get; set; }

        public decimal? MaxPrice { get; set; }
        public decimal? MinPrice { get; set; }
        public List<Fitment>? FitmentList { get; set; }
        public List<Status>? StatusList { get; set; }
    }
}
