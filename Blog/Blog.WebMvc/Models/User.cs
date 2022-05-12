using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.EntitesLayer.Concrate;
using Blog.WebMvc.Dtos;

namespace Blog.WebMvc.Models
{
    public static class Login
    {
        //field
        private static UserDto usetDto;


        public static UserDto UserDto
        {
            get
            {
                if (usetDto == null)
                    return GetUsertInfo();
                return usetDto;
            }
            set
            {
                usetDto = value;
            }
        }

        private static UserDto GetUsertInfo()
        {
            // User Bilgilerini getirecek;
            throw new NotImplementedException();
        }
    }
}