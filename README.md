# Peynir Toplamaca

Peynir Toplamaca, Unity ile hazırlanmış 3D koşu/toplama türünde bir oyun projesidir. Oyuncu karakteri ileri doğru hareket eder, A ve D tuşlarıyla şerit değiştirir ve yol parçaları oyun sırasında dinamik olarak oluşturulur.

## Kullanılan Teknolojiler

- Unity
- C#
- Rigidbody tabanlı hareket
- 3D model ve prefab kullanımı

## Temel Özellikler

- Sürekli ileri hareket eden oyuncu karakteri
- A/D tuşlarıyla sağ-sol şerit değiştirme
- Yumuşak geçiş hareketi
- Rastgele yol parçası üretimi
- Hareket eden araç/engel objeleri
- 3D çevre, karakter ve araç varlıkları

## Önemli Dosyalar

- `Peynir Toplamaca.sln`: Visual Studio çözüm dosyası.
- `Assembly-CSharp.csproj`: Unity C# proje dosyası.
- `Assets/Scenes/`: Unity sahneleri.
- `Assets/Script/CharacterController.cs`: Oyuncu hareket sistemi.
- `Assets/Script/GameManager.cs`: Yol üretim sistemi.
- `Assets/Script/CarMover.cs`: Araç/engel hareket sistemi.
- `Assets/CarKit/`, `Assets/City Kit/`, `Assets/character/`: Oyun varlıkları.

## Unity ile Açma

1. Unity Hub'ı açın.
2. `Open` seçeneğiyle `Peynir Toplamaca` klasörünü seçin.
3. Proje açıldıktan sonra `Assets/Scenes` klasöründen ana sahneyi açın.
4. Play tuşuna basarak oyunu test edin.

## Kontroller

- `A`: Sola geç
- `D`: Sağa geç

## Notlar

- `Library`, `Temp` ve benzeri Unity tarafından oluşturulan klasörler teslim için gerekli değildir.
- Oyun varlıkları `Assets` klasöründe tutulduğu için bu klasör silinmemelidir.
