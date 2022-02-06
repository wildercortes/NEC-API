using NEC.Core.Models;

namespace NEC.Core.DTOs
{
    public class DataDTO
    {
        public DataDTO(Data obj)
        {
            Id = obj.Id;
            Name = obj.Name;
            Symbol = obj.Symbol;
            Price = obj.Quote.USD.Price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Price { get; set; }
    }
}
