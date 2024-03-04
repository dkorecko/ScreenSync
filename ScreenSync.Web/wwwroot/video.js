function play_video() {
	var videoElement = document.getElementById('display-video')

	if (videoElement == null)
		return

	videoElement.play()
}