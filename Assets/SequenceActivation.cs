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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_id >= Sequence.Length) return;
            Sequence[_id].SetActive(true);
            _id++;
        }
    }
}
