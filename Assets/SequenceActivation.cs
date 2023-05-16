using UnityEngine;

public class SequenceActivation : MonoBehaviour
{
    public GameObject[] Sequence;
    private int _id;

    private void OnEnable()
    {
        foreach (var go in Sequence)
            go.SetActive(false);

        _id = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_id >= Sequence.Length) return;
            Sequence[_id].SetActive(true);
            _id++;
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (_id - 1 < 0) return;
            Sequence[_id].SetActive(false);
            _id--;
        }
    }
}
