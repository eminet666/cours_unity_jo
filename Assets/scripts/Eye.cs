using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{

    public Transform target; //public Transform target = null;
    public bool isFalling = false; // public pour le voir dans l'inspecteur
    public GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null){
            if(isFalling == false){
                transform.LookAt(target);
            }
            
        }
    }

    void OnMouseDown() {
        //clone = Instantiate(gameObject); // mais par defaut sur la scène
        clone = Instantiate(gameObject, transform.parent); // dans le parent de l'appelant
        clone.SetActive(false);

        //Debug.Break();  // met en pause le programme
        //target = null;  // se sépare de la target
        isFalling = true;
        //gameObject.AddComponent<Rigidbody>(); // ajoute un composant
        Rigidbody body = gameObject.AddComponent<Rigidbody>();
        // trainée angulaire = friction associée à la friction
        // valeur à 0.2 (défaut 0.05) pour ralentir roulement
        body.angularDrag = 0.9f;
        Debug.Log("i’m falliiiiiiiiiing");

        StartCoroutine(FallEnd());

    }

    IEnumerator FallEnd(){
        yield return new WaitForSeconds(4f); // c'est ici qu'on attends
        isFalling = false;
        Debug.Log("still alive");
    }


}
