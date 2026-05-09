using System;
using System.Collections.Generic;

namespace MyAppApi.Models;

public partial class RolePagePermission
{
    /// <summary>
    /// 고유 번호 (자동 증가)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// AspNetRoles 연결 키
    /// </summary>
    public string RoleId { get; set; } = null!;

    /// <summary>
    /// Pages 연결 키
    /// </summary>
    public int PageId { get; set; }

    /// <summary>
    /// 조회 권한 (1:허용, 0:거부)
    /// </summary>
    public bool CanRead { get; set; }

    /// <summary>
    /// 등록 권한 (1:허용, 0:거부)
    /// </summary>
    public bool CanCreate { get; set; }

    /// <summary>
    /// 수정 권한 (1:허용, 0:거부)
    /// </summary>
    public bool CanUpdate { get; set; }

    /// <summary>
    /// 삭제 권한 (1:허용, 0:거부)
    /// </summary>
    public bool CanDelete { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual Page Page { get; set; } = null!;
}
