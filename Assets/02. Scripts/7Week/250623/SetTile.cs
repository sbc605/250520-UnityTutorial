using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SetTile : MonoBehaviour
{
    public GameObject tilePrefab;
    public int rows = 5, cols = 5; // 이게 행열(바둑판 모양)

    public Button[] buttons;
    public static int turretIndex;

    // public GameObject[,] tileArray; // 2차원 배열. 값이 [a, b]이런 식으로 들어간다. int[,] 이렇게도 됨

    void Awake()
    {
        //buttons[0].onClick.AddListener(() => ChangeIndex(0));
        //buttons[1].onClick.AddListener(() => ChangeIndex(1));
        //buttons[2].onClick.AddListener(() => ChangeIndex(2));
        //buttons[3].onClick.AddListener(() => ChangeIndex(3));
        //buttons[4].onClick.AddListener(() => ChangeIndex(4));

        for (int i = 0; i < 5; i++)
        {
            int j = i;
            buttons[i].onClick.AddListener(() => ChangeIndex(j));
        }
    }


    IEnumerator Start()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                var pos = new Vector3(j, 0, i);

                GameObject tile = Instantiate(tilePrefab, pos, Quaternion.identity);
                Renderer renderer = tile.GetComponent<Renderer>();

                // tileArray[i, j] = tile; // 2차원 배열

                if ((i + j) % 2 == 0) // 짝수
                {
                    renderer.material.color = Color.white;
                }
                else // 홀수
                {
                    renderer.material.color = Color.black;
                }

                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    void ChangeIndex(int index)
    {
        turretIndex = index;
    }
}

