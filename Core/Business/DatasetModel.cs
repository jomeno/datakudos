using System;
using System.Collections.Generic;

namespace DataKudos.Core.Business
{
    public class DatasetModel{
        public string Name { get; set; }
        public IEnumerable<FieldModel> Fields { get; set; }
        
    }
    
}