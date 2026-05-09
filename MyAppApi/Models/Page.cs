using System;
using System.Collections.Generic;

namespace MyAppApi.Models;

public partial class Page
{
    /// <summary>
    /// 고유 번호 (자동 증가)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 페이지 이름
    /// </summary>
    public string PageName { get; set; } = null!;

    /// <summary>
    /// 페이지 URL 경로
    /// </summary>
    public string PageUrl { get; set; } = null!;

    /// <summary>
    /// 페이지 설명
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 메뉴 정렬 순서
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// 활성여부 (1:활성, 0:비활성)
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual ICollection<RolePagePermission> RolePagePermissions { get; set; } = new List<RolePagePermission>();
}
