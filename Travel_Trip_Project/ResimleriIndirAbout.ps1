[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$basePath = ".\site\images"

$images = @(
    @{ Name = "about-us-1-720x459.jpg"; Width = 720; Height = 459; Topic = "team,office" },
    @{ Name = "about-us-2-420x280.jpg"; Width = 420; Height = 280; Topic = "team,working" },
    @{ Name = "about-us-3-420x280.jpg"; Width = 420; Height = 280; Topic = "travel,guide" },
    @{ Name = "about-us-4-420x280.jpg"; Width = 420; Height = 280; Topic = "meeting,business" },
    @{ Name = "project-1-1200x800-original.jpg"; Width = 1200; Height = 800; Topic = "bora bora,island" },
    @{ Name = "project-1-570x380.jpg"; Width = 570; Height = 380; Topic = "bora bora,island" },
    @{ Name = "project-2-1200x800-original.jpg"; Width = 1200; Height = 800; Topic = "egypt,pyramids" },
    @{ Name = "project-2-570x380.jpg"; Width = 570; Height = 380; Topic = "egypt,pyramids" },
    @{ Name = "project-3-1200x800-original.jpg"; Width = 1200; Height = 800; Topic = "thailand,temple" },
    @{ Name = "project-3-570x380.jpg"; Width = 570; Height = 380; Topic = "thailand,temple" },
    @{ Name = "project-4-1200x800-original.jpg"; Width = 1200; Height = 800; Topic = "dominicana,beach" },
    @{ Name = "project-4-570x380.jpg"; Width = 570; Height = 380; Topic = "dominicana,beach" },
    @{ Name = "project-5-1200x800-original.jpg"; Width = 1200; Height = 800; Topic = "jamaica,resort" },
    @{ Name = "project-5-570x380.jpg"; Width = 570; Height = 380; Topic = "jamaica,resort" },
    @{ Name = "project-6-1200x800-original.jpg"; Width = 1200; Height = 800; Topic = "huntington,beach" },
    @{ Name = "project-6-570x380.jpg"; Width = 570; Height = 380; Topic = "huntington,beach" },
    @{ Name = "breadcrumbs-bg.jpg"; Width = 1920; Height = 400; Topic = "landscape,panorama" }
)

Write-Host "About sayfasi resimleri indirilmeye basliyor..." -ForegroundColor Cyan

foreach ($img in $images) {
    $targetPath = Join-Path $basePath $img.Name
    $dir = Split-Path $targetPath
    if (-not (Test-Path $dir)) {
        New-Item -ItemType Directory -Force -Path $dir | Out-Null
    }

    $randomParam = Get-Random -Minimum 1 -Maximum 9999
    $url = "https://loremflickr.com/$($img.Width)/$($img.Height)/$($img.Topic)?random=$randomParam"
    
    Write-Host "İndiriliyor: $($img.Name) ($($img.Width)x$($img.Height))... " -NoNewline
    try {
        Invoke-WebRequest -Uri $url -OutFile $targetPath -UseBasicParsing
        Write-Host "Basarili!" -ForegroundColor Green
    } catch {
        Write-Host "Hata olustu: $_" -ForegroundColor Red
    }
}
Write-Host "About resimleri basariyla indirildi." -ForegroundColor Cyan
