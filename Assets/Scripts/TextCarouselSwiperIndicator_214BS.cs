using System.Linq;
using I2.Loc;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

[System.Serializable]
    public struct CarouselItem_214BS
    { 
        private long BS_214_ABOBA1;
        public RectTransform element_214BS;
        private long BS_214_ABOBA;
        public Vector2 indicatorPosition_214BS;
    }

    [RequireComponent(typeof(CanvasRenderer))]
    public class TextCarouselSwiperIndicator_214BS : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        private int _currentEntryId_214BS;
        private bool _transitionInProgress_214BS;
        private WaitForSeconds _transitionTimer_214BS;
        private float _idleTimer_214BS;
        private Vector2 _pointerDownPosition_214BS;
        private bool _isReverced_214BS;

         [SerializeField] CarouselItem_214BS[] entries_214BS;
         [SerializeField] Vector2 startPosition_214BS;
         [SerializeField] Vector2 shownPosition_214BS;
         [SerializeField] Vector2 endPosition_214BS;
         [Space] [SerializeField] RectTransform indicator_214BS;
         [Space] [Min(0.1f)] [SerializeField] float transitionDuration_214BS = 0.1f;
         [Min(0.1f)] [SerializeField] float delayBeforeShow_214BS = 2f;
         [Space] [SerializeField] float swipeThreshold_214BS = 80f;

        private void Start()
        {
            if (LocalizationManager.CurrentLanguage == SystemLanguage.Arabic.ToString() ||
                LocalizationManager.CurrentLanguage == SystemLanguage.Hebrew.ToString())
            {
                entries_214BS = entries_214BS.Reverse().ToArray();
                (startPosition_214BS, endPosition_214BS) = (endPosition_214BS, startPosition_214BS);
                _isReverced_214BS = true;
            }
            
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
			 indicator_214BS.transform.localPosition =
                    new Vector3(entries_214BS[0].indicatorPosition_214BS.x, entries_214BS[0].indicatorPosition_214BS.y, 0f);
            _transitionTimer_214BS = new WaitForSeconds(Time.fixedDeltaTime);
            _idleTimer_214BS = delayBeforeShow_214BS;
            for (int i = 0; i < entries_214BS.Length; i++)
            {
                if (i < _currentEntryId_214BS)
                {
                    entries_214BS[i].element_214BS.anchoredPosition = startPosition_214BS;
                    if (false)
                    {
                        while (false)
                        {
                            var bs214 = SystemInfo.deviceName;
                        }
                    }
                    indicator_214BS.anchoredPosition = entries_214BS[i].indicatorPosition_214BS;
                }
                else if (i == _currentEntryId_214BS)
                    entries_214BS[i].element_214BS.anchoredPosition = shownPosition_214BS;
                else
                    entries_214BS[i].element_214BS.anchoredPosition = endPosition_214BS;
            }
        }

        private void FixedUpdate()
        {
            if (_transitionInProgress_214BS)
                return;
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            _idleTimer_214BS -= Time.fixedDeltaTime;
            
            if (_idleTimer_214BS <= 0)
                Select_214BS(_currentEntryId_214BS + 1);
        }

        private void Select_214BS(int entryIndex)
        {
            if (_currentEntryId_214BS == entryIndex || _transitionInProgress_214BS)
                return;
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            StartCoroutine(TransitionCoroutine_214BS(entryIndex));
        }

        private IEnumerator TransitionCoroutine_214BS(int entryIndex_214BS)
        {
            float buffer_214BS = 1;
            if (entryIndex_214BS == entries_214BS.Length)
            {
                entryIndex_214BS = 0;
                buffer_214BS = -1;
            }
            else if (entryIndex_214BS == -1)
            {
                entryIndex_214BS = entries_214BS.Length - 1;
                buffer_214BS = -1;
            }
            
            float directionSign_214BS = Mathf.Sign(entryIndex_214BS - _currentEntryId_214BS);
            if (entryIndex_214BS == entries_214BS.Length - 1 && _currentEntryId_214BS == 0)
            {
                yield break;
            }
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            _transitionInProgress_214BS = true;
            yield return SelectionTransitionCoroutine_214BS(_currentEntryId_214BS, directionSign_214BS * buffer_214BS, false,
                entries_214BS[entryIndex_214BS].indicatorPosition_214BS);
            yield return SelectionTransitionCoroutine_214BS(entryIndex_214BS, -directionSign_214BS * buffer_214BS, true,
                entries_214BS[entryIndex_214BS].indicatorPosition_214BS);
            _currentEntryId_214BS = entryIndex_214BS;
            _transitionInProgress_214BS = false;
            _idleTimer_214BS = delayBeforeShow_214BS;
        }

        private IEnumerator SelectionTransitionCoroutine_214BS(int entryIndex, float directionSign, bool isShowIntent,
            Vector2 targetIndicatorPosition)
        {
            Vector2 targetPosition_214BS = isShowIntent ? shownPosition_214BS : (directionSign > 0 ? startPosition_214BS : endPosition_214BS);
            if (isShowIntent)
                entries_214BS[entryIndex].element_214BS.anchoredPosition = directionSign > 0 ? startPosition_214BS : endPosition_214BS;
            Vector2 currentPosition_214BS = entries_214BS[entryIndex].element_214BS.anchoredPosition;
            float elapsedTime_214BS = 0f;
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            while (elapsedTime_214BS < transitionDuration_214BS)
            {
                elapsedTime_214BS += Time.fixedDeltaTime;
                float t_214BS = Mathf.Clamp01(elapsedTime_214BS / transitionDuration_214BS);
                entries_214BS[entryIndex].element_214BS.anchoredPosition = Vector2.Lerp(currentPosition_214BS, targetPosition_214BS, t_214BS);
                if (indicator_214BS.anchoredPosition != targetIndicatorPosition)
                    indicator_214BS.anchoredPosition = Vector2.Lerp(indicator_214BS.anchoredPosition, targetIndicatorPosition, t_214BS);
                yield return _transitionTimer_214BS;
            }

            entries_214BS[entryIndex].element_214BS.anchoredPosition = targetPosition_214BS;
            indicator_214BS.anchoredPosition = targetIndicatorPosition;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            _pointerDownPosition_214BS = eventData.position;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            float dX_214BS = eventData.position.x - _pointerDownPosition_214BS.x;
            int signValue_214BS = _isReverced_214BS ? -(int)Mathf.Sign(dX_214BS) : (int)Mathf.Sign(dX_214BS);
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            if (Mathf.Abs(dX_214BS) >= swipeThreshold_214BS)
                Select_214BS(_currentEntryId_214BS - signValue_214BS);
        }
    }