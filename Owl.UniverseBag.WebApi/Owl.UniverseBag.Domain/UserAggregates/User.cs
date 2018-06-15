using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owl.UniverseBag.Domain
{
    public class User : Entity
    {
        /// <summary>
        /// 电话号码(登录账号)
        /// </summary>
        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
