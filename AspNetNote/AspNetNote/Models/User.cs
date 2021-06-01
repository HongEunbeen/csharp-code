﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetNote.Models
{
    public class User
    {
        public User()
        {
        }
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key]
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage = "사용자 이름을 입력하세요.")]
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required(ErrorMessage = "사용자 ID를 입력하세요.")]
        public string UserId { get; set; }

        /// <summary>
        /// 사용자 PASSWORD
        /// </summary>
        [Required(ErrorMessage = "사용자 비밀번호를 입력하세요.")]
        public string UserPassword { get; set; }
    }
}
