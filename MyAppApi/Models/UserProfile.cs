using System;
using System.Collections.Generic;

namespace MyAppApi.Models;

public partial class UserProfile
{
    /// <summary>
    /// 고유 번호 (자동 증가)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// AspNetUsers 연결 키
    /// </summary>
    public string UserId { get; set; } = null!;

    /// <summary>
    /// 닉네임
    /// </summary>
    public string? NickName { get; set; }

    /// <summary>
    /// 전화번호
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// 프로필 이미지 경로
    /// </summary>
    public string? ProfileImage { get; set; }

    /// <summary>
    /// 주소
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 활성여부 (1:활성, 0:비활성)
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 수정일시
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}
