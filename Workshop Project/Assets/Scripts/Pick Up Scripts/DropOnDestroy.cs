using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DropOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject RedEnergy;
    [SerializeField] GameObject BlueEnergy;
    [SerializeField] GameObject YellowEnergy;
    [Range(0f, 1f)] 
    public float chance = 0.2f;
    public GameObject[] Energies;

    
    private void OnDestroy()
    {
        if (Random.value < chance && Energies.Length > 0)
        {
            int RandomIndex = Random.Range(0, Energies.Length );
            {
                Transform energyPosition = Instantiate(Energies[RandomIndex]).transform;
                energyPosition.position = transform.position;
            }

        }
        
        
        
    }
}
