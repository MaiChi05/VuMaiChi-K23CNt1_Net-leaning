using Microsoft.AspNetCore.Mvc;
using vmcDay06.Models;
using System;
using System.Collections.Generic;

namespace vmcDay06.Controllers
{
    public class vmcEmployeeController : Controller
    {
        
        private static readonly List<vmcEmployee> vmcListEmployee = new List<vmcEmployee>
        {
            new vmcEmployee
            {
                vmcId = 1,
                vmcName = "Vũ Mai Chi",
                vmcBirthDay = new DateTime(2005, 2, 11),
                vmcEmail = "Maichi2005@gmail.com",
                vmcPhone = "0987334235",
                vmcSalary = 15000000,
                vmcStatus = true
            },
            new vmcEmployee
            {
                vmcId = 2,
                vmcName = "Nguyễn Văn A",
                vmcBirthDay = new DateTime(2005, 8, 20),
                vmcEmail = "acuteso1tg@gmail.com",
                vmcPhone = "0912345678",
                vmcSalary = 17000000,
                vmcStatus = true
            },
            new vmcEmployee
            {
                vmcId = 3,
                vmcName = "Trịnh Trần Mai Chese",
                vmcBirthDay = new DateTime(2005, 12, 1),
                vmcEmail = "CheseinPizza@gmail.com",
                vmcPhone = "0923456789",
                vmcSalary = 12000000,
                vmcStatus = false
            },
            new vmcEmployee
            {
                vmcId = 4,
                vmcName = "Lê Quang Liêm",
                vmcBirthDay = new DateTime(2005, 3, 15),
                vmcEmail = "chessmaster@gmail.com",
                vmcPhone = "0934567890",
                vmcSalary = 16000000,
                vmcStatus = true
            },
            
            new vmcEmployee
            {
                vmcId = 5,
                vmcName = "Nguyễn Văn Oách",
                vmcBirthDay = new DateTime(2005, 9, 5),
                vmcEmail = "oachxalach@gmail.com",
                vmcPhone = "0945678901",
                vmcSalary = 0,
                vmcStatus = true
            }
        };

        public IActionResult vmcIndex()
        {
            
            return View(vmcListEmployee);
        }

        public IActionResult vmcCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult vmcCreate(vmcEmployee model)
        {
            if (ModelState.IsValid)
            {
                // Tìm Id lớn nhất hiện tại và tăng lên 1 cho nhân viên mới
                int newId = vmcListEmployee.Count > 0 ? vmcListEmployee[^1].vmcId + 1 : 1;
                model.vmcId = newId;
                vmcListEmployee.Add(model);
                
                return RedirectToAction("vmcIndex");
            }
            
            return View(model);
        }
    }
}