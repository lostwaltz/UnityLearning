using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class OnClickInputNameButton : EventArgs
{
    public OnClickInputNameButton()
    {
    }
}
internal class NameTagChangeEvent : EventArgs
{
    public NameTagChangeEvent(string name, bool create)
    {
        this.name = name;
        this.create = create;
    }

    public string name;
    public bool create;
}