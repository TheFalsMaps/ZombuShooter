using UnityEngine;

namespace Source.Shop
{
    public class AttachmentPurchase : MonoBehaviour
    {
        [SerializeField] private GameObject attachment;
        [SerializeField] private GameObject[] attachmentsSprites;
        [SerializeField] private GameObject[] indicators;
        private static int _index = 0;
        private bool _firstClick = true;
        
        public void OnClick()
        {
            if (_firstClick)
            {
                foreach (var spriteObject in attachmentsSprites)
                {
                    spriteObject.SetActive(true);
                }
                
                attachment.SetActive(true);
                _index++;
            }
            else if (!_firstClick)
            {
                foreach (var spriteObject in attachmentsSprites)
                {
                    spriteObject.SetActive(false);
                }
                
                attachment.SetActive(false);
                _index--;
            }
            
            for (int i = 0; i < indicators.Length; i++)
            {
                indicators[i].SetActive(i < _index);
            }

            _firstClick = !_firstClick;
        }
    }
}
