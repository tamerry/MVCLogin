﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCLogin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int UserID { get; set; }
        [DisplayName("Kullanıcı adı :")]
        [Required(ErrorMessage ="Gerekli")]
        public string UserName { get; set; }
        [DisplayName("Parola :")]
        [Required(ErrorMessage = "Gerekli")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}