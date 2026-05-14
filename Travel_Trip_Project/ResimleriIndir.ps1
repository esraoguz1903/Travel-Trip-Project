[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$basePath = ".\site\images"

# İndirilecek resimlerin listesi ve boyutları/konuları
$images = @(
    @{ Name = "swiper-slide-1.jpg"; Width = 1920; Height = 1080; Topic = "paris,travel" },
    @{ Name = "swiper-slide-2.jpg"; Width = 1920; Height = 1080; Topic = "beach,vacation" },
    @{ Name = "swiper-slide-3.jpg"; Width = 1920; Height = 1080; Topic = "nature,explore" },
    @{ Name = "landing-private-airlines-01-570x370.jpg"; Width = 570; Height = 370; Topic = "paris,city" },
    @{ Name = "landing-private-airlines-02-570x370.jpg"; Width = 570; Height = 370; Topic = "boston,city" },
    @{ Name = "landing-private-airlines-03-570x370.jpg"; Width = 570; Height = 370; Topic = "venice,italy" },
    @{ Name = "landing-private-airlines-04-570x370.jpg"; Width = 570; Height = 370; Topic = "spain,city" },
    @{ Name = "landing-private-airlines-05-570x370.jpg"; Width = 570; Height = 370; Topic = "egypt,desert" },
    @{ Name = "landing-private-airlines-06-570x370.jpg"; Width = 570; Height = 370; Topic = "london,uk" },
    @{ Name = "landing-private-airlines-7-570x415.jpg"; Width = 570; Height = 415; Topic = "hotel,room" },
    @{ Name = "landing-private-airlines-8-570x415.jpg"; Width = 570; Height = 415; Topic = "vacation,planning" },
    @{ Name = "landing-private-airlines-9-570x415.jpg"; Width = 570; Height = 415; Topic = "earth,travel" },
    @{ Name = "quote-user-1-210x210.jpg"; Width = 210; Height = 210; Topic = "face,portrait,woman" },
    @{ Name = "quote-user-2-210x210.jpg"; Width = 210; Height = 210; Topic = "face,portrait,woman" },
    @{ Name = "quote-user-3-210x210.jpg"; Width = 210; Height = 210; Topic = "face,portrait,woman" },
    @{ Name = "banner\background-03-1920x310.jpg"; Width = 1920; Height = 310; Topic = "landscape,travel" },
    @{ Name = "banner\background-03-3840x620.jpg"; Width = 3840; Height = 620; Topic = "landscape,travel" },
    @{ Name = "banner\foreground-03-1600x310.png"; Width = 1600; Height = 310; Topic = "plane,travel" },
    @{ Name = "banner\foreground-03-3200x620.png"; Width = 3200; Height = 620; Topic = "plane,travel" }
)

Write-Host "Resimler indirilmeye basliyor..." -ForegroundColor Cyan

foreach ($img in $images) {
    $targetPath = Join-Path $basePath $img.Name
    $dir = Split-Path $targetPath
    if (-not (Test-Path $dir)) {
        New-Item -ItemType Directory -Force -Path $dir | Out-Null
    }

    # Her resmin birbirinden farkli olmasi icin rastgele bir sayi ekliyoruz
    $randomParam = Get-Random -Minimum 1 -Maximum 9999
    
    # Seyahat konseptine uygun resimler indirmek icin loremflickr kullaniyoruz
    $url = "https://loremflickr.com/$($img.Width)/$($img.Height)/$($img.Topic)?random=$randomParam"
    
    Write-Host "İndiriliyor: $($img.Name) ($($img.Width)x$($img.Height))... " -NoNewline
    try {
        Invoke-WebRequest -Uri $url -OutFile $targetPath -UseBasicParsing
        Write-Host "Basarili!" -ForegroundColor Green
    } catch {
        Write-Host "Hata olustu: $_" -ForegroundColor Red
    }
}
Write-Host "Tüm resimler basariyla indirildi. Artik projeyi calistirabilirsiniz!" -ForegroundColor Cyan
