﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntitesLayer.Concrate;

namespace Blog.DataAccessLayer.Abstract
{
    public interface ISocialMediaDal
    {
        /*
         * Generic bir yapı oluşturalım..
         *
         *
         */

        void Add(SocialMedia socialMedia);

        void Delete(SocialMedia socialMedia);

        void Update(SocialMedia socialMedia);

        List<SocialMedia> GetAll();

        SocialMedia GetSocialMedia(int id);

        SocialMedia GetFirstModel();

    }
}
