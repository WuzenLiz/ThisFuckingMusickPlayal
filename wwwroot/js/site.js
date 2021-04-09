function Updatetime() {
    var player = document.getElementById("song");
    var length = player.duration;
    var current_time = player.currentTime;

    // calculate total length of value
    var totalLength = calculateTotalValue(length);
    document.getElementById("end-time").innerHTML = totalLength;

    // calculate current value time
    var currentTime = calculateCurrentValue(current_time);
    document.getElementById("start-time").innerHTML = currentTime;
}

function initProgressBar() {
    var player = document.getElementById("song");
    var length = player.duration;
    var current_time = player.currentTime;

    // calculate total length of value
    var totalLength = calculateTotalValue(length);
    document.getElementById("end-time").innerHTML = totalLength;

    // calculate current value time
    var currentTime = calculateCurrentValue(current_time);
    document.getElementById("start-time").innerHTML = currentTime;

    var progressbar = document.getElementById("seek-obj");
    progressbar.value = player.currentTime / player.duration;
    progressbar.addEventListener("click", seek);

    if (player.currentTime == player.duration) {
        document.getElementById("play-pause-btn").className = "";
    }

    function seek(event) {
        var percent = event.offsetX / this.offsetWidth;
        player.currentTime = percent * player.duration;
        progressbar.value = percent / 100;
    }
}

function initPlayers(num) {
    // pass num in if there are multiple audio players e.g 'player' + i

    for (var i = 0; i < num; i++) {
        (function () {
            // Variables
            // ----------------------------------------------------------
            // audio embed object
            var playerContainer = document.getElementsByClassName("seeking-bar"),
                player = document.getElementById("song"),
                isPlaying = false,
                playBtn = document.getElementById("play-pause-btn");

            // Controls Listeners
            // ----------------------------------------------------------
            if (playBtn != null) {
                playBtn.addEventListener("click", function () {
                    togglePlay();
                });
            }

            // Controls & Sounds Methods
            // ----------------------------------------------------------
            function togglePlay() {
                if (player.paused == false) {
                    player.pause();
                    isPlaying = false;
                    document.getElementById("play-pause-btn").innerHTML =
                        '<i class="fas fa-play"></i>';
                } else {
                    player.play();
                    document.getElementById("play-pause-btn").innerHTML =
                        '<i class="fas fa-pause"></i>';
                    isPlaying = true;
                }
            }
        })();
    }
}

function calculateTotalValue(length) {
    var minutes = Math.floor(length / 60),
        seconds_int = length - minutes * 60,
        seconds_str = seconds_int.toString(),
        seconds = seconds_str.substr(0, 2),
        time = minutes + ":" + seconds;

    return time;
}

function calculateCurrentValue(currentTime) {
    var current_hour = parseInt(currentTime / 3600) % 24,
        current_minute = parseInt(currentTime / 60) % 60,
        current_seconds_long = currentTime % 60,
        current_seconds = current_seconds_long.toFixed(),
        current_time =
            (current_minute < 10 ? "0" + current_minute : current_minute) +
            ":" +
            (current_seconds < 10 ? "0" + current_seconds : current_seconds);

    return current_time;
}

initPlayers(jQuery(".seeking-bar").length);
var audio = document.getElementById("song");
audio.volume = document.querySelector("#volume").value / 100;
var tmp_volume = audio.volume;
console.log(tmp_volume);
function mutesound() {
    if (!audio.muted) {
        audio.muted = true;
        tmp_volume = audio.volume;
        document.getElementById("volume-ctrl").innerHTML =
            '<i class="fas fa-volume-mute"></i>';
        document.getElementById("volume-slider").value = 0;
        outputUpdate(0);
    } else {
        audio.muted = false;
        document.getElementById("volume-slider").value = tmp_volume * 100;
        outputUpdate(tmp_volume * 100);
        document.getElementById("volume-ctrl").innerHTML =
            '<i class="fas fa-volume"></i>';
    }
}
function outputUpdate(vol) {
    document.querySelector("#volume").value = vol;
    audio.volume = vol / 100;
}
