using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer.Abstract
{
    public interface ISocialMediaService<SocialMedia>
    {
        void Add(SocialMedia socialMedia);

        void Delete(SocialMedia socialMedia);

        void Update(SocialMedia socialMedia);

        List<SocialMedia> GetAll();

        SocialMedia GetSocialMedia(int id);

    }
}
