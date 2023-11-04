using MovieAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieAppProject.ViewModels
{
    public class CustomerFormVIewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}