using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.ReferenceData
{
    [Table("ReferenceData")]
    public class ReferenceDataItem : Entity
    {
        // An empty constructor is required by EF Core
        private ReferenceDataItem() { }

        public ReferenceDataItem(ReferenceDataType referenceDataType, string text)
        {
            DataType = referenceDataType;
            Text = text;
        }

        [Column("DataType")]
        public ReferenceDataType DataType { get; set; }

        [Column("Text")]
        public string Text { get; set; }
    }
}
