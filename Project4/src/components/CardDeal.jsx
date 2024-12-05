import { card,content,content2 } from "../assets";
import styles, { layout } from "../style";
import Button from "./Button";

const CardDeal = () => (
  <section className={layout.section}>
    <div className={layout.sectionInfo}>
      <h2 className={styles.heading2}>
        Complete projects efficiently <br className="sm:block hidden" /> and
        quickly.
      </h2>
      <p className={`${styles.paragraph} max-w-[470px] mt-5`}>
        
      Swiftly and precisely accomplish projects, 
      benefitting from our streamlined approach 
      that ensures efficiency and successful outcomes.
      </p>
      <a href="https://brainwave-3d32a.firebaseapp.com/" target="_blank" rel="noopener noreferrer">
        <Button styles={`mt-10`} />
      </a>
    </div>

    <div className={layout.sectionImg}>
      <img src={content2} alt="billing" className="w-[100%] h-[100%]" />
    </div>
  </section>
);

export default CardDeal;
