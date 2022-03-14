using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataKudos.Core.Business;


namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
     public class DatasetsController : ControllerBase
     {
        private readonly ILogger<DatasetsController> _log;

        public DatasetsController(ILogger<DatasetsController> log){
             _log = log;
        }

        [HttpGet]
         public IActionResult Get(){

             var result = new List<DatasetModel>(){
                new DatasetModel(){ 
                    Name = "Employee",
                    Fields = new List<FieldModel>(){ 
                         new FieldModel(){ Name = "Id", Type = "long"},
                         new FieldModel(){ Name = "Surname", Type = "string"},
                         new FieldModel(){ Name = "BirthDate", Type = "datetime"},
                         new FieldModel(){ Name = "Height", Type = "decimal"},
                    } 
                },
                new DatasetModel(){ 
                    Name = "Compensation",
                    Fields = new List<FieldModel>(){ 
                         new FieldModel(){ Name = "Id", Type = "long"},
                         new FieldModel(){ Name = "EmployeeId", Type = "long"},
                         new FieldModel(){ Name = "Remuneration", Type = "decimal"},
                    } 
                },
             };

             return Ok(result);

         }
         
     }   
    
}