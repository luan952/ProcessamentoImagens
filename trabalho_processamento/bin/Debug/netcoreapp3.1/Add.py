import cv2

image1 = cv2.imread("img1.png")
image2 = cv2.imread("ImagemGaussiana.jpg")

image3 = cv2.add(image1, image2)
cv2.imwrite("imagemSoma.png", image3) 
