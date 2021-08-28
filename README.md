# VisExtBootChanger
Changes the Windows Vista boot screen easily for Extended Kernel users.

VisExtBootChanger is a easy-to-use boot changer for Windows Vista. It uses a custom NTOSKRNL or 16 color BMP image file to replace the current system file in System32, without having to replace the file manually. It works by using Resource Hacker (to replace an BMP image file from an original NTOSKRNL) and FFMPEG (to merge a preview image with a transparent progress square PNG file).

![FirstUse1](https://user-images.githubusercontent.com/50250400/131221847-e5d87acc-a5b9-4946-a48c-8680a9abb497.png)
![FirstUse2](https://user-images.githubusercontent.com/50250400/131221851-05ae776d-035d-484a-a0af-87d67d67806b.png)

# Requirements

Make sure you have these requirements before using this program. Unfollowing these requirements may cause damage to your computer, leading to a boot failure.

- Windows Vista with Extended Kernel installed
- x64 system
- ntoskrnl.exe (version 6.0.6003.20555)

# STEPS

# How to make boot image correctly:

NOTE: If you want to apply an image without making one, skip to step 4 (unless mentioned in step 2).

1. Make the image whatever you want, whatever you are using GIMP, Photoshop, or even paint.net. Black background looks best (recommended), as using a custom background in an image will make the boot screen horrible, and will also appear black spots in the top left of the screen and on the progress bar when progress squares move. Don't forget to add a progress bar (without a progress square) into your image (without it will only show the progress square).

2. Make sure that the image needs to be precisely 8-bit integer precision and needs to be rendered as a 16 color bitmap.

3. After rendering the picture, open the image in Pixelformer and export it as BMP again to make the bitmap work perfectly and show in good detail. Make sure that the bpp is 4, otherwise, you will get a black background with only showing the progress square if it's set to 8 or higher, as shown in the picture.

![image3](https://user-images.githubusercontent.com/50250400/131221927-93f2910d-c829-4904-b5a1-9028453440da.png)

4. Open VisExtBootChanger and head to File > Open > Image file.

5. Select the BMP file.

6. Select “Use this image as a bootscreen”.

![image2](https://user-images.githubusercontent.com/50250400/131221942-a348bc17-b4bd-492b-9058-a1819fd3a7a6.png)

7. You are prompted that you have these requirements followed. If so, press any key. The installation will take less than a second to about 2-3 seconds. After installation, you will be greeted with a 5-second countdown to restart your computer automatically.

![image1](https://user-images.githubusercontent.com/50250400/131221949-8ca5c409-573a-44e2-83ef-aac500961edd.png)

8. You will now be greeted with your new boot screen.

# How to revert back to default boot screen

To apply the default boot screen:

1. Go to File > Presets
2. Choose Versions > 1985 - 2006 (XP and Vista) > Vista > RTM (default)
3. Apply and restart to see the default boot screen.
