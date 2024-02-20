﻿using System.Collections;
using UnityEngine;

public class ScratchMono_SetVolume : A_ScratchBlockableMono
{

    public float m_volumePercent;

    public override IEnumerator DoTheScratchableStuff()
    {
        AudioListener.volume = Mathf.Clamp(m_volumePercent, 0.0f, 1.0f);
        yield return null;
    }



}
