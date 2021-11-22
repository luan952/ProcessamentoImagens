import cv2
import numpy as np

img1 = cv2.imread('img1.png')

resultado = cv2.GaussianBlur(img1, (7,7), 7)

cv2.imwrite('ImagemGaussiana.jpg', resultado)

cv2.destroyAllWindows