//using ALTAVA.Tween;
//using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ALTAVA.UI.Contents
{
    public class UIItemMainPage : MonoBehaviour
    {
  //      [SerializeField] RectTransform rectTransform;
  //      //[SerializeField] UIButton btnSelect;
  //      //[SerializeField] UITexture texMain;
  //      //[SerializeField] UILabel textTitle;
  //      //[SerializeField] UIButton btnVisit;
  //      //[SerializeField] UILabel textVisit;

  //      public RectTransform RectTransform { private set; get; }

  //      public float duration = 0.2f;
  //      public bool isClick { get; set; }
  //      private float btnYPos = -500;
  //      private float textScale = 3;
  //      private float itemDefaultHeight = 400;
  //      private float itemChangeHeight = 600;

  //      private void Start()
  //      {
  //          SetDefalut();
  //          RectTransform = GetComponent<RectTransform>();
  //      }

  //      private void SetDefalut()
  //      {
  //          var localPos = btnVisit.RectTransform.localPosition;
  //          localPos.y = btnYPos;
  //          btnVisit.RectTransform.localPosition = localPos;

  //          rectTransform.sizeDelta = new Vector2(0, itemDefaultHeight);
  //          texMain.rectTransform.localScale = Vector2.one * 1.2f;
  //          textTitle.rectTransform.localScale = Vector2.one;
  //          btnVisit.RectTransform.anchoredPosition = Vector2.zero;
  //          btnVisit.image.color = Color.clear;
  //          textVisit.color = Color.clear;
  //      }
		//private void SetSizeItem(bool _isClick)
  //      {
  //          var height = _isClick == true ? itemChangeHeight : itemDefaultHeight;
  //          rectTransform.DOSizeDelta(new Vector2(0,height), duration).onComplete = ()=> { rectTransform.DOKill(); };
  //      }
  //      private void SetScaleTexture(bool _isClick)
  //      {
  //          var scale = _isClick == true ? textScale : 1.2f;
  //          texMain.rectTransform.DOScale(scale, duration).onComplete = () => { texMain.DOKill(); };
  //          //TweenController.Instance.PlayTweenUI(AltavaUI_TweenType.LocalScale, texMain.gameObject, scale, 0.2f);
  //      }
  //      private void SetScaleText(bool _isClick) 
  //      {
  //          var scale = _isClick == true ? textScale : 1;
  //          textTitle.rectTransform.DOScale(scale, duration).onComplete = () => { textTitle.DOKill(); };
  //          //TweenController.Instance.PlayTweenUI(AltavaUI_TweenType.LocalScale, textTitle.gameObject, scale, 0.2f);
  //      }
  //      private void SetActiveBtn(bool _isClick)
  //      {
  //          var yPos = _isClick == true ? 0 : btnYPos;
  //          btnVisit.RectTransform.DOAnchorPosY(yPos, duration).onComplete = () => { btnVisit.DOKill(); };
  //          //TweenController.Instance.PlayTweenUI(AltavaUI_TweenType.LocalMoveY, btnVisit.gameObject, yPos, 0.2f);
  //          var fade = _isClick == true ? Color.white : Color.clear;
  //          btnVisit.image.DOColor(fade, duration).onComplete = () => { btnVisit.DOKill();};
  //          var fade2 = _isClick == true ? Color.black : Color.clear;
  //          textVisit.DOColor(fade2, duration).onComplete = () => { btnVisit.DOKill();};
  //          //TweenController.Instance.PlayTweenUI(AltavaUI_TweenType.Fade, btnVisit.gameObject, fade, 1);
  //      }

		//public void SetEvent(bool _isClick)
  //      {
  //          if (isClick == false && _isClick == false)
  //              return;
  //          if (isClick == true && _isClick == true)
  //              _isClick = false;
  //          isClick = _isClick;
  //          SetSizeItem(isClick);
  //          SetScaleTexture(isClick);
  //          SetScaleText(isClick);
  //          SetActiveBtn(isClick);
  //      }

  //      public void SetClickAction(System.Action<UIItemMainPage> _action) 
  //      {
  //          btnSelect.AddButtonClickEvent(()=> _action.Invoke(this));
  //      }
    }
}