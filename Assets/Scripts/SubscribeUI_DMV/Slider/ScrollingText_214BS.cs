using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollingText_214BS : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform_214BS;

    public event Action<int> OnPageChange_214BS;

     [SerializeField] private float percentThreshold_214BS = 0.2f;
     [SerializeField] private float easing_214BS = 0.5f;
     [SerializeField] private float autoSmothDelayTime_214BS = 2.5f;
     [SerializeField] private float autoSmothRecoveryTime_214BS = 2f;


    private int _currentPage_214BS = 1;

    private float panelLocation_214BS;
    private float width_214BS;
    private int totalPages_214BS;

    private Coroutine autoMove_214BS;
    private Coroutine smoothMove_214BS;

    public int CurrentPage_214BS
    {
        get => _currentPage_214BS;
        private set
        {
            _currentPage_214BS = value;
            OnPageChange_214BS?.Invoke(_currentPage_214BS);
        }
    }

    async void Awake()
    {
        rectTransform_214BS = this.GetComponent<RectTransform>();

        await Task.Yield();
        await Task.Yield();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        var corners_214BS = new Vector3[4];

        rectTransform_214BS.GetWorldCorners(corners_214BS);

        width_214BS = new Rect(corners_214BS[0], new Vector2(
            rectTransform_214BS.lossyScale.x * rectTransform_214BS.rect.size.x,
            rectTransform_214BS.lossyScale.y * rectTransform_214BS.rect.size.y)).width;

        for (int i_214BS = 0; i_214BS < this.transform.childCount; i_214BS++)
        {
            if (this.transform.GetChild(i_214BS).gameObject.activeSelf)
            {
                totalPages_214BS++;
            }
        }

        panelLocation_214BS = transform.position.x;
    }

    async void OnEnable()
    {
        await Task.Yield();
        await Task.Yield();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        if (this.gameObject.activeSelf && this.gameObject.activeInHierarchy)
        {
            autoMove_214BS = StartCoroutine(nameof(AutoSmoothMove));
        }
    }

    public void OnDrag(PointerEventData data)
    {
        StopCoroutine(autoMove_214BS);
        var difference_214BS = data.pressPosition.x - data.position.x;
        transform.position = new Vector3(panelLocation_214BS - difference_214BS, transform.position.y, transform.position.z);
    }

    public void OnEndDrag(PointerEventData data)
    {
        var percentage_214BS = (data.pressPosition.x - data.position.x) / width_214BS;
        if (Mathf.Abs(percentage_214BS) >= percentThreshold_214BS)
        {
            var newLocation_214BS = panelLocation_214BS;
            if (percentage_214BS > 0 && CurrentPage_214BS < totalPages_214BS)
            {
                CurrentPage_214BS++;
                newLocation_214BS -= width_214BS;
            }
            else if (percentage_214BS < 0 && CurrentPage_214BS > 1)
            {
                CurrentPage_214BS--;
                newLocation_214BS += width_214BS;
            }
            else if (percentage_214BS > 0 && CurrentPage_214BS == totalPages_214BS)
            {
                // Scroll from 5 to 1
                CurrentPage_214BS = 1;
                newLocation_214BS += width_214BS * (totalPages_214BS - 1);
            }

            smoothMove_214BS = StartCoroutine(SmoothMove(newLocation_214BS));
            panelLocation_214BS = newLocation_214BS;
        }
        else
        {
            smoothMove_214BS = StartCoroutine(SmoothMove(panelLocation_214BS));
        }

        autoMove_214BS = StartCoroutine(nameof(AutoSmoothMove));
    }

    private IEnumerator RecoverAutoSmoothMove()
    {
        yield return new WaitWhile(() => smoothMove_214BS != null);
        yield return new WaitForSeconds(autoSmothRecoveryTime_214BS);

        autoMove_214BS = StartCoroutine(nameof(AutoSmoothMove));
    }

    private IEnumerator AutoSmoothMove()
    {
        yield return new WaitForSeconds(autoSmothDelayTime_214BS);
        while (true)
        {
            if (!this.gameObject.activeInHierarchy)
            {
                break;
            }

            if (CurrentPage_214BS + 1 > totalPages_214BS)
            {
                CurrentPage_214BS = 1;
                panelLocation_214BS += width_214BS * (totalPages_214BS - 1);
            }
            else
            {
                CurrentPage_214BS++;
                panelLocation_214BS -= width_214BS;
            }

            StartCoroutine(SmoothMove(panelLocation_214BS));

            yield return new WaitForSeconds(autoSmothDelayTime_214BS);
        }
    }

    private IEnumerator SmoothMove(float endpos)
    {
        var start_214BS = transform.position;
        var end_214BS = new Vector3(endpos, transform.position.y, transform.position.z);

        float percent_214BS = 0f;
        while (percent_214BS <= 1.0)
        {
            percent_214BS += Time.deltaTime / easing_214BS;
            transform.position = Vector3.Lerp(start_214BS, end_214BS, Mathf.SmoothStep(0f, 1f, percent_214BS));
            yield return null;
        }

        smoothMove_214BS = null;
    }
}
