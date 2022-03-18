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
                    FriendlyName = "Employee",
                    Fields = new List<FieldModel>(){ 
                         new FieldModel(){ Name = "Id", FriendlyName = "Id", Type = "long"},
                         new FieldModel(){ Name = "Surname", FriendlyName = "Surname", Type = "string"},
                         new FieldModel(){ Name = "BirthDate", FriendlyName = "Birth Date", Type = "datetime"},
                         new FieldModel(){ Name = "Height", FriendlyName = "Height", Type = "decimal"},
                         new FieldModel(){ Name = "Description", FriendlyName = "Description", Type = "string"},
                    } 
                },
                new DatasetModel(){ 
                    Name = "Compensation",
                    FriendlyName = "Compensation",
                    Fields = new List<FieldModel>(){ 
                         new FieldModel(){ Name = "Id", FriendlyName = "Id", Type = "long"},
                         new FieldModel(){ Name = "EmployeeId", FriendlyName = "Employee Id", Type = "long"},
                         new FieldModel(){ Name = "Remuneration", FriendlyName = "Remuneration", Type = "decimal"},
                         new FieldModel(){ Name = "Periodicity", FriendlyName = "Periodicity", Type = "int"},
                         new FieldModel(){ Name = "Description", FriendlyName = "Description", Type = "string"},
                         new FieldModel(){ Name = "Date", FriendlyName = "Date", Type = "datetime"},
                    } 
                },
                new DatasetModel(){ 
                    Name = "MedicalInsurance",
                    FriendlyName = "Medical Insurance",
                    Fields = new List<FieldModel>(){ 
                         new FieldModel(){ Name = "Id", FriendlyName = "Id", Type = "long"},
                         new FieldModel(){ Name = "EmployeeId", FriendlyName = "Employee Id", Type = "long"},
                         new FieldModel(){ Name = "InsurancePlan", FriendlyName = "Insurance Plan", Type = "string"},
                         new FieldModel(){ Name = "Description", FriendlyName = "Description", Type = "string"},
                         new FieldModel(){ Name = "Social", FriendlyName = "Social", Type = "string"},
                         new FieldModel(){ Name = "Date", FriendlyName = "Date", Type = "datetime"},
                    } 
                },
                new DatasetModel(){ 
                    Name = "Vacation",
                    FriendlyName = "Vacation", 
                    Fields = new List<FieldModel>(){ 
                         new FieldModel(){ Name = "Id", FriendlyName = "Id", Type = "long"},
                         new FieldModel(){ Name = "SubscriptionPlan", FriendlyName = "Subscription Plan", Type = "string"},
                         new FieldModel(){ Name = "Description", FriendlyName = "Description", Type = "string"},
                         new FieldModel(){ Name = "StartDate", FriendlyName = "Start Date", Type = "datetime"},
                         new FieldModel(){ Name = "EndDate", FriendlyName = "End Date", Type = "datetime"},
                    } 
                },
             };

             

             return Ok(result);

         }
         
     }   
    
}