using System;
using System.Collections.Generic;

namespace MyAppApi.Models;

public partial class UserLog
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
    /// 활동 유형 (로그인/로그아웃/접근 등)
    /// </summary>
    public string Action { get; set; } = null!;

    /// <summary>
    /// 접근한 페이지 URL
    /// </summary>
    public string? PageUrl { get; set; }

    /// <summary>
    /// 접속 IP 주소
    /// </summary>
    public string? IpAddress { get; set; }

    /// <summary>
    /// 활동 일시
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
