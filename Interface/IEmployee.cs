﻿using Demo_POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_POC.Interface
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAllEmployees();
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        Employee GetEmployeeData(int id);
        int DeleteEmployee(int id);
        List<City> GetCities();
    }
}
