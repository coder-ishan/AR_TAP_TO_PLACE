using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    // Start is called before the first frame update
    private PlaceIndicator placeIndicator;
    public GameObject objectToPlace;
    public GameObject newPlacedObject;
    [SerializeField] public GameObject button;
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
        button.SetActive(true);
    }

    // Update is called once per frame
    public void clickToPlace()
    {
        newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
        //button.SetActive(false);

    }
}
