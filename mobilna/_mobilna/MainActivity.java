package com.example.mobilna;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.HashMap;
import java.util.Map;
import java.util.Random;

public class MainActivity extends AppCompatActivity {

    Button btn_roll;
    Button btn_reset;
    ImageView[] images;
    TextView tv_rollResult;
    TextView tv_gameResult;
    int totalScore = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        btn_roll = findViewById(R.id.btn_roll);
        btn_reset = findViewById(R.id.btn_reset);

        images = new ImageView[] {
                findViewById(R.id.img_1),
                findViewById(R.id.img_2),
                findViewById(R.id.img_3),
                findViewById(R.id.img_4),
                findViewById(R.id.img_5),
        };

        tv_rollResult = findViewById(R.id.tv_rollResult);
        tv_gameResult = findViewById(R.id.tv_gameResult);

        btn_roll.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Random rand = new Random();
                HashMap<Integer, Integer> numbers = new HashMap<>();
                int currentScore = 0;

                for (ImageView img : images){
                    int randNum = rand.nextInt(6) + 1;

                    int imgResId = getResources().getIdentifier("k" + randNum, "drawable", getPackageName());

                    img.setImageResource(imgResId);

                    if (!numbers.containsKey(randNum)){
                        numbers.put(randNum, 1);
                    }
                    else {
                        numbers.put(randNum, numbers.get(randNum) + 1);
                    }
                }

                for (Map.Entry<Integer, Integer> entry : numbers.entrySet()){
                    int miniCounter = 0;
                    if (entry.getValue() >= 2){
                        for (int i = 0; i < entry.getValue(); i++){
                            miniCounter += entry.getKey();
                        }
                        currentScore += miniCounter;
                    }
                }
                totalScore += currentScore;

                tv_rollResult.setText("Wynik tego losowania: " + currentScore);
                tv_gameResult.setText("Wynik gry: " + totalScore);
            }
        });

        btn_reset.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                for (ImageView img : images){
                    img.setImageResource(R.drawable.question);
                }
                totalScore = 0;
                tv_gameResult.setText("Wynik gry: 0");
                tv_rollResult.setText("Wynik tego losowania: 0");
            }
        });
    }
}