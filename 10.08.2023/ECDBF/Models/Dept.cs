using System;
using System.Collections.Generic;

namespace EFDBF.Models;

public partial class Dept
{
    public int Deptno { get; set; }

    public string? Dname { get; set; }

    public virtual Empm? Empm { get; set; }
}
