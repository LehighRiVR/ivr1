using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private static LTDescr delay;

    public string header;        
    public string content;
        
    public void OnPointerEnter(PointerEventData eventData)
    {
        delay = LeanTween.delayedCall(0.3f, () =>
        {
            TooltipSystem.SHOWtooltip(content, header);
        });        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.cancel(delay.uniqueId);
        TooltipSystem.HIDEtooltip();
    }

    public void Start()
    {

        #region FlyBy
        try
        {
            if (GameObject.Find("FlyHighlight (1)").activeSelf)
            {
                content = "fb_0";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (2)").activeSelf)
            {
                content = "fb_1";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (3)").activeSelf)
            {
                content = "fb_2";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (4)").activeSelf)
            {
                content = "fb_5";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (5)").activeSelf)
            {
                content = "fb_6";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (6)").activeSelf)
            {
                content = "fb_7";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (7)").activeSelf)
            {
                content = "fb_8";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (8)").activeSelf)
            {
                content = "fb_9";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (9)").activeSelf)
            {
                content = "fb_11";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("FlyHighlight (10)").activeSelf)
            {
                content = "fb_12";
            }
        }
        catch (System.Exception) { }

        #endregion

        #region Francis
        try
        {
                if (GameObject.Find("FrancisHighlight (1)").activeSelf)
                {
                    content = "hpc_1a";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("FrancisHighlight (2)").activeSelf)
                {
                    content = "hpc_1b_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("FrancisHighlight (3)").activeSelf)
                {
                    content = "hpc_1b_3";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("FrancisHighlight (4)").activeSelf)
                {
                    content = "hpc_1b_4";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("FrancisHighlight (5)").activeSelf)
                {
                    content = "hpc_1b_2";
                }
            }
            catch (System.Exception) { }
        
        #endregion

        #region Rockport
            try
            {
                if (GameObject.Find("RockHighlight (1)").activeSelf)
                {
                    content = "hpc_2a";
                }            
            }
            catch(System.Exception) { }

        #endregion

        #region Lehigh Gap
            try
            {
                if (GameObject.Find("LehighHighlight (1)").activeSelf)
                {
                    content = "hpc_3a_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("LehighHighlight (2)").activeSelf)
                {
                    content = "hpc_3a_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("LehighHighlight (3)").activeSelf)
                {
                    content = "hpc_3a_3";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("LehighHighlight (4)").activeSelf)
                {
                    content = "hpc_3b_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("LehighHighlight (5)").activeSelf)
                {
                    content = "hpc_3b_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("LehighHighlight (6)").activeSelf)
                {
                    content = "hpc_3c_1";
                }
            }
            catch (System.Exception) { }

        #endregion

        #region Walnutport
            try
            {
                if (GameObject.Find("WalnutHighlight (1)").activeSelf)
                {
                    content = "hpc_4a";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("WalnutHighlight (2)").activeSelf)
                {
                    content = "hpc_4b_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("WalnutHighlight (3)").activeSelf)
                {
                    content = "hpc_4b_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("WalnutHighlight (4)").activeSelf)
                {
                    content = "hpc_4c_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("WalnutHighlight (5)").activeSelf)
                {
                    content = "hpc_4c_2";
                }
            }
            catch (System.Exception) { }

        #endregion

        #region Cementon
            try
            {
                if (GameObject.Find("CementHighlight (1)").activeSelf)
                {
                    content = "hpc_5_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("CementHighlight (2)").activeSelf)
                {
                    content = "hpc_5_2";
                }
            }
            catch (System.Exception) { }

        #endregion

        #region Thomas Iron
        try
        {
            if (GameObject.Find("ThomasHighlight (1)").activeSelf)
            {
                content = "hpc_6_1";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("ThomasHighlight (2)").activeSelf)
            {
                content = "hpc_6_3";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("ThomasHighlight (3)").activeSelf)
            {
                content = "hpc_6_2";
            }
        }
        catch (System.Exception) { }

        try
        {
            if (GameObject.Find("ThomasHighlight (4)").activeSelf)
            {
                content = "hpc_6_4";
            }
        }
        catch (System.Exception) { }

        #endregion

        #region Hamilton Street
            try
            {
                if (GameObject.Find("HamiltonHighlight (1)").activeSelf)
                {
                    content = "hpc_7_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("HamiltonHighlight (2)").activeSelf)
                {
                    content = "hpc_7_1";
                }
            }
            catch (System.Exception) { }

        #endregion

        #region Bethlehem
            try
            {
                if (GameObject.Find("BethHighlight (1)").activeSelf)
                {
                    content = "hpc_8a_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("BethHighlight (2)").activeSelf)
                {
                    content = "hpc_8a_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("BethHighlight (3)").activeSelf)
                {
                    content = "hpc_8b_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("BethHighlight (4)").activeSelf)
                {
                    content = "hpc_8b_3";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("BethHighlight (5)").activeSelf)
                {
                    content = "hpc_8b_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("BethHighlight (6)").activeSelf)
                {
                    content = "hpc_8c_1";
                }
            }
            catch (System.Exception) { }

        #endregion

        #region Easton
            try
            {
                if (GameObject.Find("EastonHighlight (1)").activeSelf)
                {
                    content = "hpc_9a_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("EastonHighlight (2)").activeSelf)
                {
                    content = "hpc_9a_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("EastonHighlight (3)").activeSelf)
                {
                    content = "hpc_9a_2";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("EastonHighlight (4)").activeSelf)
                {
                    content = "hpc_9c_1";
                }
            }
            catch (System.Exception) { }

            try
            {
                if (GameObject.Find("EastonHighlight (5)").activeSelf)
                {
                    content = "hpc_9c_2";
                }
            }
            catch (System.Exception) { }

        #endregion

    }

}
